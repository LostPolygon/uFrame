using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkView
{
    
}
public class NetworkCommand : ICommand
{
    public string OwnerIdentifier { get; set; }
    public string Identifier { get; set; }
    public ICommand ActualCommand { get; set; }

    public event CommandEvent OnCommandExecuted
    {
        add { ActualCommand.OnCommandExecuted += value; }
        remove { ActualCommand.OnCommandExecuted -= value; }
    }

    public event CommandEvent OnCommandExecuting
    {
        add { ActualCommand.OnCommandExecuting += value; }
        remove { ActualCommand.OnCommandExecuting -= value; }
    }

    public object Sender
    {
        get { return ActualCommand.Sender; }
        set { ActualCommand.Sender = value; }
    }

    public object Parameter
    {
        get { return ActualCommand.Parameter; }
        set { ActualCommand.Parameter = value; }
    }

    public IEnumerator Execute()
    {
        return ActualCommand.Execute();
    }
}
public interface IUFrameNetworking
{
    void SyncView(ViewBase view);
    void SyncViewModel<T>(string identifier, T viewModel);

    void SyncProperty<TPropertyValueType>(string viewIdentifier, ModelPropertyBase property);

}

public class NetworkManager
{
    public IUFrameNetworking Networking { get; set; }
    public Dictionary<string, INetworkView> NetworkViews { get; set; }


    public string SendCommand(INetworkView view, ICommand command)
    {
        var networkCommand = command as NetworkCommand;
        if (networkCommand != null)
        {
            Networking.RPC(networkCommand.OwnerIdentifier, networkCommand.Identifier);
        }
    }
    public string AddNetworkView(string viewModelIdentifier, INetworkView networkView)
    {
        NetworkViews.Add(networkView.Identifier, networkView);
        foreach (var view in networkView.SyncronizedCommands)
        {

        }
    }

    public string InstantiateNetworkView(GameObject prefab, ViewModel model)
    {
        // Send message to syncronize the viewmodel
        
    }

    public NetworkCommand CreateNetworkCommand(string identifier, ICommand command)
    {
        return new NetworkCommand()
        {
            ActualCommand = command,
            Identifier = identifier
        };
    }

    public void CreateNetworkProperty(string identifier, ModelPropertyBase property)
    {
        
    }
}



public class UFNetworkView : ViewComponent, INetworkView
{
    public string Identifier
    {
        get { return View.ViewModelObject.Identifier; }
    }

    public NetworkManager Manager
    {
        get
        {
            return GameManager.Container.Resolve<NetworkManager>();
        }
    }

    public override void PreBind(ViewBase viewBase)
    {
        base.PreBind(viewBase);
        
    }

    public override void PostBind(ViewBase viewBase)
    {
        base.PostBind(viewBase);
        Manager.AddNetworkView(this);
    }

    public virtual void Initialize()
    {
        
    }
}
public interface INetworkView
{
    string Identifier { get; }

}

