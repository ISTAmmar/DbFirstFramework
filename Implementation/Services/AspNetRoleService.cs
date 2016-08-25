using System;
using System.Collections.Generic;
using System.Linq;
using Models.DomainModels;
using Repository.Repositories;

namespace Implementation.Services
{
    public class AspNetRoleService
    {
        #region Private

        private AspNetRoleRepository repository { get; set; }

        #endregion

        #region Constructor

        //public AspNetRoleService()
        //{
        //    repository = new AspNetRoleRepository();
        //}

        #endregion

        #region Public

        public IEnumerable<AspNetRole> GetAll()
        {
            return repository.GetAll();
        }

        public AspNetRole FindById(int roleId)
        {
            return repository.Find(roleId);
        }

        public void DeleteRole(int roleId)
        {
            var role = repository.Find(roleId);
            if (role == null)
            {
                throw new NullReferenceException("Role not found.");
            }
            // Remove Users from Role
            if (role.Users.Any())
            {
                foreach (var user in role.Users.ToList())
                {
                    role.Users.Remove(user);
                }
            }
            repository.Delete(role);
            repository.SaveChanges();
        }

        public bool AddRole(AspNetRole role)
        {
            if (!repository.CheckIfExist(role))
            {
                repository.Add(role);
                repository.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateRole(AspNetRole role)
        {
            if (!repository.CheckIfExist(role))
            {
                repository.Update(role);
                repository.SaveChanges();
                return true;
            }
            return false;
        }

        #endregion
    }
}