var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var student = /** @class */ (function () {
    function student(id) {
        this.studentid = id;
    }
    return student;
}());
var College = /** @class */ (function (_super) {
    __extends(College, _super);
    function College(id, name) {
        var _this = _super.call(this, id) || this;
        _this.studentname = name;
        return _this;
    }
    College.prototype.detailsStudent = function () {
        console.log(this.studentid + " " + this.studentname);
        return this.studentid;
    };
    return College;
}(student));
var s = new College(12, "manoj");
s.detailsStudent();
