using System;
using System.Collections.Generic;
using System.Linq;
using Invert.uFrame;
using Invert.uFrame.Editor.ElementDesigner;
using UnityEditor;
using UnityEngine;

public class ViewDrawer : DiagramNodeDrawer<ViewData>
{
    private ElementDataBase _forElement;

    public ViewDrawer()
    {
    }

    public override GUIStyle BackgroundStyle
    {
        get
        {

            return UFStyles.DiagramBox2;
        }
    }

    public ViewDrawer(ViewData data, ElementsDiagram diagram)
        : base(data, diagram)
    {
        Diagram = diagram;

    }

    public override bool AllowCollapsing
    {
        get { return true; }
    }


    private NodeItemHeader _behavioursHeader;

    protected override IEnumerable<DiagramSubItemGroup> GetItemGroups()
    {
        yield break;
    }

    public override GUIStyle ItemStyle
    {
        get { return UFStyles.Item4; }
    }
    [Inject("ViewDoubleClick")]
    public IEditorCommand DoubleClickCommand { get; set; }

    public override void DoubleClicked()
    {
        base.DoubleClicked();
        if (DoubleClickCommand != null)
        {
            Execute(DoubleClickCommand);
        }
    }

    public override float HeaderSize
    {
        get { return base.HeaderSize + 6; }
    }

    protected override void DrawHeader(ElementsDiagram diagram, bool importOnly)
    {
        base.DrawHeader(diagram, importOnly);
        var subTitlePosition = Data.HeaderPosition.Scale(Scale);
        subTitlePosition.y += (15 * Scale);
        var style = new GUIStyle(EditorStyles.miniLabel);
        style.fontSize = Mathf.RoundToInt(10 * Scale);
        style.alignment = TextAnchor.MiddleCenter;
        GUI.Label(subTitlePosition,Data.BaseViewName,style);
    }

    protected override void DrawContent(ElementsDiagram diagram, bool importOnly)
    {
        base.DrawContent(diagram, importOnly);
    }

    protected override void DrawSelectedItem(IDiagramNodeItem nodeItem, ElementsDiagram diagram)
    {
        base.DrawSelectedItem(nodeItem, diagram);
    }
}