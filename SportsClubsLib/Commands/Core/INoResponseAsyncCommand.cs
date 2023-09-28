namespace SportsClubsLib.Commands.Core
{
    public interface INoResponseAsyncCommand<in TData>
    {
        Task Execute(TData data);
    }
}
