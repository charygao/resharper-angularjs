using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.JavaScript.Impl.Tree;
using JetBrains.ReSharper.Psi.JavaScript.Resolve;

namespace JetBrains.ReSharper.Plugins.AngularJS.Psi.Parsing.Tree
{
    internal class FilterExpression : JavaScriptExpressionBase
    {
        public override NodeType NodeType
        {
            get { return AngularJsElementType.FILTER_EXPRESSION; }
        }

        // TODO: Make the children available via properties

        public override IJavaScriptType GetJsType(IJsLocalElementResolver context)
        {
            return JavaScriptType.Empty;
        }
    }
}