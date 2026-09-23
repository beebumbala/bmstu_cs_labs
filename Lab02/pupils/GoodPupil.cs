namespace Lab02.pupils;

public class GoodPupil : Pupil
{
    public override void Study() => Console.WriteLine("good: study");
    public override void Read() => Console.WriteLine("good: read");
    public override void Write() => Console.WriteLine("good: write");
    public override void Relax() => Console.WriteLine("good: relax");
}
