namespace Intro.Business;
using Intro.Entities;
using Intro.DataAccess.Abstracts;

//namespace Intro;

//Metod tutan class:
public class CourseManager
{
    //Global degisken olarak tanimladim ki diger metodlar da  bu degiskene erisebilsin.
    //Course[] courses=new Course[3];

    // //constructor
    // public CourseManager()
    // {
    //     //SIMULASYON YAPTIK: DB'DEN GELMIS GIBI
    //     // Course course1 = new Course();
    //     // course1.Id = 1;

    //     // Course course2 = new Course();
    //     // course2.Id = 2;

    //     // Course course3 = new Course();
    //     // course3.Id = 3;

        
    //     // courses[0] = course1;//bunlar database'den dinamik gelecekler.
    //     // courses[1] = course2;
    //     // courses[2] = course3;

    // }

    //dependency injection
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }


    public List<Course> GetAll()
    {
        //Veri kaynağından çekilir

        //is kurallarini gecince
        //CourseDal courseDal = new CourseDal(); --> newlemek yanlış

        return _courseDal.GetAll();
        
    }



}
