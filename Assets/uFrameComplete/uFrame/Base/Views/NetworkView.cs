using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class NetworkView
//{
    
//}
//public class NetworkCommand : ICommand
//{
//    public string OwnerIdentifier { get; set; }
//    public string Identifier { get; set; }
//    public ICommand ActualCommand { get; set; }

//    public event CommandEvent OnCommandExecuted
//    {
//        add { ActualCommand.OnCommandExecuted += value; }
//        remove { ActualCommand.OnCommandExecuted -= value; }
//    }

//    public event CommandEvent OnCommandExecuting
//    {
//        add { ActualCommand.OnCommandExecuting += value; }
//        remove { ActualCommand.OnCommandExecuting -= value; }
//    }

//    public object Sender
//    {
//        get { return ActualCommand.Sender; }
//        set { ActualCommand.Sender = value; }
//    }

//    public object Parameter
//    {
//        get { return ActualCommand.Parameter; }
//        set { ActualCommand.Parameter = value; }
//    }

//    public IEnumerator Execute()
//    {
//        return ActualCommand.Execute();
//    }
//}
//public interface IUFrameNetworking
//{
//    void Connect(string endpoint, int port, string password = null);
//}

//public class UFUnityNetworking : NetworkView, IUFrameNetworking
//{
//    [Inject]
//    public LevelLoadViewModel ProgressViewModel { get; set; }

//    public void Awake()
//    {
        
//    }

//    public bool _SendDisconnectNotification = false;
//    public int _Connections = 5;
//    public int _ServerPort = 1337;
//    public bool _UseNat = false;

//    public bool IsServer { get; set; }

//    public IEnumerator Begin()
//    {

//        ProgressViewModel.Set(0f,"Initializing Server");
//    }


//    public void StartServer()
//    {
//        Network.InitializeServer(_Connections, _ServerPort, _UseNat);
//    }

//    public void Connect(string endpoint,int port,string password = null)
//    {
//        Network.Connect(endpoint, port, password);
//    }

//    public void Disconnect()
//    {
//        Network.Disconnect();
//    }

//    public void CloseConnection(string user)
//    {
        
//        Network.CloseConnection(Network.player, _SendDisconnectNotification);
//    }
    
//}

//public class NetworkManager
//{
//    public IUFrameNetworking Networking { get; set; }
//    public Dictionary<string, INetworkView> NetworkViews { get; set; }

//    public void RegisterView(INetworkView view)
//    {
//        if (NetworkViews.ContainsKey(view.Identifier))
//        {
//            NetworkViews.Add(view.Identifier,view);
//        }
//    }

//    public void SendCommand(string identifier, ICommand command)
//    {
        
//    }

//    public void SendPropertyChanged(string instanceId, string propertyId, object value)
//    {
        
//    }

//    public void Instantiate(string prefabName, ViewModel model)
//    {
        
        
//    }

//}

//public class ViewModelSerializer<T> : IViewModelSerializer
//{
    
//}

//public interface IViewModelSerializer
//{
//}

//public class UFNetworkView : ViewComponent, INetworkView
//{
//    public bool IsOwner { get; set; }
//    public string Identifier
//    {
//        get { return View.ViewModelObject.Identifier; }
//    }

//    public NetworkManager Manager
//    {
//        get
//        {
//            return GameManager.Container.Resolve<NetworkManager>();
//        }
//    }

//    public override void PreBind(ViewBase viewBase)
//    {
//        base.PreBind(viewBase);
        
//    }

//    public override void PostBind(ViewBase viewBase)
//    {
//        base.PostBind(viewBase);
//        Manager.RegisterView(this);
//    }

//    public virtual void Initialize()
//    {
        
//    }
//}
//public interface INetworkView
//{
//    string Identifier { get; }

//}

////public interface IPacket
////{
////    void Send()
////}

////public interface IStream
////{
////    void WriteInt(int value);
////    void WriteBool(bool value);
////    void WriteString(string value);
////    void WriteFloat(float value);
////    void WriteVector3(Vector3 value);
////    void WriteVector2(Vector2 value);
    
////}