using Intro.Entities;

namespace Intro;

public interface ICourseDal
{
    List<Course> GetAll();
    void Add(Course course);
}
