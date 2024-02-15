using Intro.Entities;

namespace Intro;

public class CourseDal:ICourseDal
{
    List<Course> courses;
    public CourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;

        Course course2 = new Course();
        course2.Id = 2;

        Course course3 = new Course();
        course3.Id = 3;

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
