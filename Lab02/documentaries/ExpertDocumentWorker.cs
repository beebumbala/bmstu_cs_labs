namespace Lab02.documentaries;

public class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument() => Console.WriteLine("document saved in new format");
}
