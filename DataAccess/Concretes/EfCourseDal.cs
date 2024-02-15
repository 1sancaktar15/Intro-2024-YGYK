// See https://aka.ms/new-console-template for more information

using Intro.Entities;

namespace Intro;

public class EfCourseDal:ICourseDal
{
    List<Course> courses;
    public EfCourseDal()
    {
        Course course1 = new Course();
        course1.Id = 4;

        Course course2 = new Course();
        course2.Id = 5;

        Course course3 = new Course();
        course3.Id = 6;

        courses = new List<Course> {course1,course2,course3};
    }
    public List<Course> GetAll() 
    { 
        //sql, burada db islemleri yapilir.
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
}
