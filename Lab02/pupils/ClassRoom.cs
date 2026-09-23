namespace Lab02.pupils;

public class ClassRoom
{
    private Pupil[] _pupils = new Pupil[4];

    public ClassRoom(params Pupil[] pupils)
    {
        for (int i = 0; i < _pupils.Length; i++)
            _pupils[i] = i < pupils.Length ? pupils[i] : new Pupil();
    }

    public void Show()
    {
        for (int i = 0; i < _pupils.Length; i++)
        {
            Console.WriteLine($"pupil {i + 1}: ");
            _pupils[i].Study();
            _pupils[i].Read();
            _pupils[i].Write();
            _pupils[i].Relax();
        }
    }
}
