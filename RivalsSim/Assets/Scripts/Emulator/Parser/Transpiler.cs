using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using UnityEngine;

class Transpiler
{
    private RivalsParserBaseListener listener;

    public static string transpile(string gmlInput)
    {
        ICharStream stream = CharStreams.fromstring(gmlInput);
        ITokenSource lexer = new RivalsLexer(stream);
        ITokenStream tokens = new CommonTokenStream(lexer);
        RivalsParser parser = new RivalsParser(tokens);
        parser.BuildParseTree = true;
        IParseTree tree = parser.script();
        ScriptReader reader = new ScriptReader();
        ParseTreeWalker.Default.Walk(reader, tree);
        return "Maslow";
    }
}
