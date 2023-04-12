using FuncAndActoin.Helpers;
using FuncAndActoin.Entities;

var bobStudents = SEDC.Students.Where(x => x.FirstName.ToLower() == "bob");
bobStudents.ToList().PrintEntities();

var bobStidentsSQL = from student in SEDC.Students
                     where student.FirstName.ToLower() == "bob"
                     select student;

var firstNames = SEDC.Students.Select(x => x.FirstName).ToList();

List<string> firstNamesSql = (from student in SEDC.Students
                              select student.FirstName).ToList();
firstNamesSql.PrintSimple();

//Advanced query
var partTimeStudentsSubjecs = SEDC.Students.Where(student => student.IsPartTime)
                                            .Where(student => student.Subjects
                                            .Where(sub => sub.Type == Academy.Programming).Count() > 0).ToList();

var parTimeStudentSQL = from student in SEDC.Students
                        where student.IsPartTime
                        where (from subject in student.Subjects
                               where subject.Type == Academy.Programming
                               select subject).Count() > 0
                        select student;
parTimeStudentSQL.ToList().PrintEntities();

// LINQ - All subjects form selected pt students -
var allSubjectsForPtStudents = SEDC.Students.Where(st => st.IsPartTime)
                                            .SelectMany(st => st.Subjects)
                                            .Distinct().ToList();
allSubjectsForPtStudents.PrintEntities();