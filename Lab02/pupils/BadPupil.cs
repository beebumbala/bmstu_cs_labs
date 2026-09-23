namespace Lab02.pupils;

public class BadPupil : Pupil
{
    public override void Study() => Console.WriteLine("bad: study");
    public override void Read() => Console.WriteLine("bad: read");
    public override void Write() => Console.WriteLine("bad: write");
    public override void Relax() => Console.WriteLine("bad: relax");
}
