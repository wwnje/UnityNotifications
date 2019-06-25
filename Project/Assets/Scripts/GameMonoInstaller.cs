using UnityEngine;
using Zenject;

public class GameMonoInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        PuzzlesKingdom.Notifications.NotificationsInstaller.Install(Container);
    }
}