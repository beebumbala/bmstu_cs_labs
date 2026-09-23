namespace Lab02.pupils;

public class Pupil
{
    public virtual void Study() => Console.WriteLine("pupil: study");
    public virtual void Read() => Console.WriteLine("pupil: read");
    public virtual void Write() => Console.WriteLine("pupil: write");
    public virtual void Relax() => Console.WriteLine("pupil: relax");
}