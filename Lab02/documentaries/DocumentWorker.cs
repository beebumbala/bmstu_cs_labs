namespace Lab02.documentaries;

public class DocumentWorker
{
    public virtual void OpenDocument() => Console.WriteLine("document opened");
    public virtual void EditDocument() => Console.WriteLine("edit available in pro version");
    public virtual void SaveDocument() => Console.WriteLine("save available in pro version");
}
