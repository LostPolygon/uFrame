public interface IBindingProvider
{
    void PreBind(ViewBase viewBase);
    void Bind(ViewBase view);
    void Unbind(ViewBase viewBase);
    void PostBind(ViewBase viewBase);
}