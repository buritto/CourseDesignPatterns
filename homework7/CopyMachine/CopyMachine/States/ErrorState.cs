namespace CopyMachine.States
{
    public static class Error
    {
        public static Context GetError(Context context, string errorMessage)
        {
            context.Error = new ContextError
            {
                ErrorMessage = errorMessage,
                HaveError = true
            };

            context.ChangeState(new ProfitState(context));

            return context;
        }
    }
}