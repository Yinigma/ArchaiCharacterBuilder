using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class ScriptReader : RivalsParserBaseListener
{

    override
    public void EnterScript(RivalsParser.ScriptContext context)
    {
        foreach( RivalsParser.StatementContext statement in context.GetRuleContexts<RivalsParser.StatementContext>())
        {
            processStatement(statement);
        }
    }

    private string processStatement(RivalsParser.StatementContext statement)
    {
        if(statement.nonBreakingStatement() != null)
        {
            return processStatement(statement.nonBreakingStatement());
        }
        else if(statement.BREAK() != null )
        {
            return "break";
        }
        return "";
    }

    private string processStatement(RivalsParser.NonBreakingStatementContext statement)
    {
        if(statement.declaration() != null)
        {
            return processDeclaration(statement.declaration());
        }
        if (statement.assignStatement() != null)
        {
            return processAssignment(statement.assignStatement());
        }
        return "";
    }

    //TODO Figure out what function calls will ultimately be used to implement the language features.
    private string processAssignment(RivalsParser.AssignStatementContext assignStatement)
    {
        if(assignStatement.Identifier() != null)
        {
            if(assignStatement.VAR() != null)
            {
                return "properties.Add(\"" + assignStatement.Identifier().GetText() + "\", new GMLVariable("+assignStatement.expression()+", Scope.LOCAL));";
            }
            else
            {
                return "properties.Add(\"" + assignStatement.Identifier().GetText() + "\", new GMLVariable(" + assignStatement.expression() + ", Scope.INSTANCE));";
            }
        }
        if()
        {

        }
    }

    private string processDeclaration(RivalsParser.DeclarationContext declaration)
    {
        return "properties.Add(\""+declaration.Identifier().GetText()+"\", new GMLVariable(null, Scope.LOCAL));";
    }
}
