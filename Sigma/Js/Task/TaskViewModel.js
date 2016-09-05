
var TaskViewModel = function () {
    var self = this;
    self.header = "My Tasks";
    self.newTaskName = ko.observable();
    self.newTaskStatus = ko.observable();
    self.tasks = ko.observableArray([new Task({ TaskName: "Learn jQuery", Status: true }), new Task({ TaskName: "Learn Knockout", Status: false })]);
    self.addNewTask = function () {
        self.tasks.push(new Task({ TaskName: self.newTaskName(), Status: self.newTaskStatus() }));
    }
    self.initialize = function() {
        $.ajax({
            url: "/Api/DashboardApi",
            method: "GET",
            contentType: "application/json",
            success: function (result) {
                alert(result.message);
            }
        });
    }

    self.initialize();
}

ko.applyBindings(new TaskViewModel());