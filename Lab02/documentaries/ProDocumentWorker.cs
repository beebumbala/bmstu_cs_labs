namespace Lab02.documentaries;

public class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument() => Console.WriteLine("document edited");
    public override void SaveDocument() => Console.WriteLine("saved in old format, other formats in expert version");
}
