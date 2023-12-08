//
// Author:
//   Aaron Bockover <aaron@abock.dev>
//
// Copyright (c) 2019 Aaron Bockover. All rights reserved.
// Licensed under the MIT License.

namespace DotLang.CodeAnalysis.Syntax
{
    public enum VisitKind
    {
        Invalid,
        Enter,
        Leave
    }

    public interface SyntaxVisitor
    {
        public virtual bool VisitSyntaxNode<T>(
            T node,
            VisitKind visitKind) where T: SyntaxNode
            => true;

        public void VisitSyntaxToken(SyntaxToken token)
        {
        }

        public bool VisitSyntaxTree(
            SyntaxTree tree,
            VisitKind visitKind)
            => VisitSyntaxNode(tree, visitKind);

        public bool VisitPreprocessorDirectiveSyntax(
            PreprocessorDirectiveSyntax directive,
            VisitKind visitKind)
            => VisitSyntaxNode(directive, visitKind);

        public bool VisitNodeIdentifierSyntax(
            NodeIdentifierSyntax nodeIdentifier,
            VisitKind visitKind)
            => VisitSyntaxNode(nodeIdentifier, visitKind);

        public bool VisitPortSyntax(
            PortSyntax port,
            VisitKind visitKind)
            => VisitSyntaxNode(port, visitKind);

        public bool VisitAttributeSyntax(
            AttributeSyntax attribute,
            VisitKind visitKind)
            => VisitSyntaxNode(attribute, visitKind);

        public bool VisitAttributeListSyntax(
            AttributeListSyntax attributeList,
            VisitKind visitKind)
            => VisitSyntaxNode(attributeList, visitKind);

        public bool VisitToplevelGraphSyntax(
            ToplevelGraphSyntax toplevelGraph,VisitKind visitKind)
            => VisitSyntaxNode(toplevelGraph, visitKind);

        public bool VisitGraphSyntax(
            GraphSyntax graph,
            VisitKind visitKind)
            => VisitToplevelGraphSyntax(graph, visitKind);

        public bool VisitDigraphSyntax(
            DigraphSyntax digraph,
            VisitKind visitKind)
            => VisitToplevelGraphSyntax(digraph, visitKind);

        public bool VisitStatementSyntax(
            StatementSyntax statement,
            VisitKind visitKind)
            => VisitSyntaxNode(statement, visitKind);

        public bool VisitEmptyStatementSyntax(
            EmptyStatementSyntax emptyStatement,
            VisitKind visitKind)
            => VisitStatementSyntax(emptyStatement, visitKind);

        public bool VisitNameValueStatementSyntax(
            NameValueStatementSyntax nameValueStatement,
            VisitKind visitKind)
            => VisitStatementSyntax(nameValueStatement, visitKind);

        public bool VisitAttributeStatementSyntax(
            AttributeStatementSyntax attributeStatement,
            VisitKind visitKind)
            => VisitStatementSyntax(attributeStatement, visitKind);

        public bool VisitNodeStatementSyntax(
            NodeStatementSyntax nodeStatement,
            VisitKind visitKind)
            => VisitStatementSyntax(nodeStatement, visitKind);

        public bool VisitEdgeStatementSyntax(
            EdgeStatementSyntax edgeStatement,
            VisitKind visitKind)
            => VisitStatementSyntax(edgeStatement, visitKind);

        public bool VisitSubgraphStatementSyntax(
            SubgraphStatementSyntax subgraphStatement,
            VisitKind visitKind)
            => VisitStatementSyntax(subgraphStatement, visitKind);
    }
}
