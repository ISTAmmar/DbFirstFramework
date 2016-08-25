
//function Tasks(task) {
//    return {
//        Title: ko.observable(task.title),
//        IsDone: ko.observable(task.isDone)
//    }
//}

var Task = function () {
    var self = this;
    self.TaskId = ko.observable();
    self.TaskName = ko.observable();
    self.Status = ko.observable();
    self.TaskPriority = ko.observable();
    self.StartDate = ko.observable();
    self.EndDate = ko.observable();
    self.Progress = ko.observable();
    self.IsParent = ko.observable();
    self.ParentTaskId = ko.observable();
    self.ParentTask = ko.observable();
}
