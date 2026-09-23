namespace Lab02.pupils;

public class ExcellentPupil : Pupil
{
    public override void Study() => Console.WriteLine("excellent: study");
    public override void Read() => Console.WriteLine("excellent: read");
    public override void Write() => Console.WriteLine("excellent: write");
    public override void Relax() => Console.WriteLine("excellent: relax");
}
