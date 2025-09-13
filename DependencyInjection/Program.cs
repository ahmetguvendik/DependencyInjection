using DependencyInjection;

IOgretmen ogretmen = new Ogretmen("Ayşe", "Demir");
ClassRoom classRoom = new ClassRoom(ogretmen);

Console.WriteLine(classRoom.GetTeacherInfo());


