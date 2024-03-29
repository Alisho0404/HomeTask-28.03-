using Domain.Models;
using Infrastrcture.Services;

var courseService = new CourseService();
var studentService = new StudentService();
var mentorService = new MentorService();
var groupService = new GroupService();
var mentorCourseService = new MentorCourseService();
var studentCourseService = new StudentCourseService();

var student1 = new Student()
{
    FirstName = "Sam",
    LastName = "Abdulaziz",
    Phone = "990876543"
};
var student2 = new Student()
{
    FirstName = "Bob",
    LastName = "MArli",
    Phone = "7852015"
};
var student3 = new Student()
{
    FirstName = "Sho",
    LastName = "Mirov",
    Phone = "7896541"
};
/* studentService.AddStudent(student1);
studentService.AddStudent(student2);
studentService.AddStudent(student3); */

var mentor1 = new Mentor()
{
    FirstName = "Dilovarsho",
    LastName = "Dilyobov",
    Position = "Director"
};
var mentor2 = new Mentor()
{
    FirstName = "Nazira",
    LastName = "Bandishoeva",
    Position = "shuroi zanon"
};
var mentor3 = new Mentor()
{
    FirstName = "Saidnasimov",
    LastName = "Qaysar",
    Position = "zam director"
};
/* mentorService.AddMentor(mentor1);
mentorService.AddMentor(mentor2);
mentorService.AddMentor(mentor3); */

var course1 = new Course()
{
    CourseName = ".Net"
};
var course2 = new Course()
{
    CourseName = "C#"
};
var course3 = new Course()
{
    CourseName = "SQL"
};
/* courseService.AddCourse(course1);
courseService.AddCourse(course2);
courseService.AddCourse(course3); */

var group1 = new Group()
{
    GroupName = "C# 13",
    CourseId = 2

};
var group2 = new Group()
{
    GroupName = ".Net 10",
    CourseId = 1

};
var group3 = new Group()
{
    GroupName = "C# 14",
    CourseId = 2

};
/* groupService.AddGroup(group1);
groupService.AddGroup(group2);
groupService.AddGroup(group3); */

var mentorCourse1 = new MentorCourse()
{
    CourseId = 1,
    MentorId = 3
};
var mentorCourse2 = new MentorCourse()
{
    CourseId = 2,
    MentorId = 2
};
var mentorCourse3 = new MentorCourse()
{
    CourseId = 3,
    MentorId = 1
};
/* mentorCourseService.Add(mentorCourse1);
mentorCourseService.Add(mentorCourse2);
mentorCourseService.Add(mentorCourse3);*/

var studentCourse1 = new StudentCourse()
{
    CourseId = 1,
    StudentId = 2
};
var studentCourse2 = new StudentCourse()
{
    CourseId = 2,
    StudentId = 3
};
var studentCourse3 = new StudentCourse()
{
    CourseId = 3,
    StudentId = 1
};
/* studentCourseService.Add(studentCourse1);
studentCourseService.Add(studentCourse2);
studentCourseService.Add(studentCourse3); */