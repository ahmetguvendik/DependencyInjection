namespace ConsoleApp1;

public class ClassRoom
{
    public IOgretmen Teacher { get; }

    public ClassRoom(IOgretmen teacher)
    {
        Teacher = teacher;
    }

    public string GetTeacherInfo()
    {
        return Teacher.GetInfo();
    }
}


