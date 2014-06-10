using System.Collections.Generic;
using Invert.uFrame.Editor;

public class EnumDataGenerator : NodeItemGenerator<EnumData>
{
    public override IEnumerable<CodeGenerator> CreateGenerators(ElementDesignerData diagramData, EnumData item)
    {
        yield return new EnumCodeGenerator()
        {
            EnumData = item,
            Filename = diagramData.ViewModelsFileName,
        };
    }
}