namespace CopyMachine.States
{
    public class SelectDocumentState : BaseState, IState
    {
        public SelectDocumentState(Context context) : base(context)
        {
        }

        public new void SelectDocument(string documentName)
        {
            if (string.IsNullOrWhiteSpace(documentName))
            {
                Context = Error.GetError(Context, "document name null or white space");
                return;
            }

            Context.ChangeState(new RepeatPrintState(Context));
        }
    }
}