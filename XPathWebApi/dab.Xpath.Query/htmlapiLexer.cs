//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from htmlapi.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class htmlapiLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, VALUE_STRING=7, SELECT=8, 
		FROM=9, WHERE=10, TOP=11, INTEGER=12, AS=13, SORT=14, SORT_TYPE=15, GROUP=16, 
		COMPARE_OPERATORS=17, LOGIC_OPERATIONS=18, WS=19;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "A", "B", "C", "D", "E", 
		"F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", 
		"T", "U", "V", "W", "X", "Y", "Z", "VALUE_CHAR", "VALUE_STRING", "SELECT", 
		"FROM", "WHERE", "TOP", "INTEGER", "AS", "SORT", "SORT_TYPE", "GROUP", 
		"LIKE", "COMPARE_OPERATORS", "AND_OR", "NEGATE", "LOGIC_OPERATIONS", "WS", 
		"WHITESPACE"
	};


	public htmlapiLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public htmlapiLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "','", "'*'", "';'", "'.'", "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, "VALUE_STRING", "SELECT", "FROM", 
		"WHERE", "TOP", "INTEGER", "AS", "SORT", "SORT_TYPE", "GROUP", "COMPARE_OPERATORS", 
		"LOGIC_OPERATIONS", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "htmlapi.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static htmlapiLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x15', '\x110', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x4', ')', 
		'\t', ')', '\x4', '*', '\t', '*', '\x4', '+', '\t', '+', '\x4', ',', '\t', 
		',', '\x4', '-', '\t', '-', '\x4', '.', '\t', '.', '\x4', '/', '\t', '/', 
		'\x4', '\x30', '\t', '\x30', '\x4', '\x31', '\t', '\x31', '\x4', '\x32', 
		'\t', '\x32', '\x4', '\x33', '\t', '\x33', '\x3', '\x2', '\x3', '\x2', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', 
		'\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', 
		'\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', 
		'\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3', '\x17', '\x3', '\x17', 
		'\x3', '\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', 
		'\x3', '\x1A', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x3', '\x1C', 
		'\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1F', 
		'\x3', '\x1F', '\x3', ' ', '\x3', ' ', '\x3', '!', '\x3', '!', '\x3', 
		'\"', '\x3', '\"', '\x3', '\"', '\x5', '\"', '\xAB', '\n', '\"', '\x3', 
		'#', '\x3', '#', '\a', '#', '\xAF', '\n', '#', '\f', '#', '\xE', '#', 
		'\xB2', '\v', '#', '\x3', '#', '\x3', '#', '\x3', '$', '\x3', '$', '\x3', 
		'$', '\x3', '$', '\x3', '$', '\x3', '$', '\x3', '$', '\x3', '%', '\x3', 
		'%', '\x3', '%', '\x3', '%', '\x3', '%', '\x3', '&', '\x3', '&', '\x3', 
		'&', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', '\'', '\x3', '\'', '\x3', 
		'\'', '\x3', '\'', '\x3', '(', '\x6', '(', '\xCD', '\n', '(', '\r', '(', 
		'\xE', '(', '\xCE', '\x3', ')', '\x3', ')', '\x3', ')', '\x3', '*', '\x3', 
		'*', '\x3', '*', '\x3', '*', '\x3', '*', '\x3', '+', '\x3', '+', '\x3', 
		'+', '\x3', '+', '\x3', '+', '\x3', '+', '\x3', '+', '\x3', '+', '\x3', 
		'+', '\x5', '+', '\xE2', '\n', '+', '\x3', ',', '\x3', ',', '\x3', ',', 
		'\x3', ',', '\x3', ',', '\x3', ',', '\x3', '-', '\x3', '-', '\x3', '-', 
		'\x3', '-', '\x3', '-', '\x3', '.', '\x3', '.', '\x3', '.', '\x3', '.', 
		'\x3', '.', '\x3', '.', '\x3', '.', '\x3', '.', '\x3', '.', '\x5', '.', 
		'\xF8', '\n', '.', '\x3', '/', '\x3', '/', '\x3', '/', '\x3', '/', '\x3', 
		'/', '\x3', '/', '\x3', '/', '\x5', '/', '\x101', '\n', '/', '\x3', '\x30', 
		'\x3', '\x30', '\x3', '\x30', '\x3', '\x30', '\x3', '\x31', '\x3', '\x31', 
		'\x5', '\x31', '\x109', '\n', '\x31', '\x3', '\x32', '\x3', '\x32', '\x3', 
		'\x32', '\x3', '\x32', '\x3', '\x33', '\x3', '\x33', '\x2', '\x2', '\x34', 
		'\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', 
		'\b', '\xF', '\x2', '\x11', '\x2', '\x13', '\x2', '\x15', '\x2', '\x17', 
		'\x2', '\x19', '\x2', '\x1B', '\x2', '\x1D', '\x2', '\x1F', '\x2', '!', 
		'\x2', '#', '\x2', '%', '\x2', '\'', '\x2', ')', '\x2', '+', '\x2', '-', 
		'\x2', '/', '\x2', '\x31', '\x2', '\x33', '\x2', '\x35', '\x2', '\x37', 
		'\x2', '\x39', '\x2', ';', '\x2', '=', '\x2', '?', '\x2', '\x41', '\x2', 
		'\x43', '\x2', '\x45', '\t', 'G', '\n', 'I', '\v', 'K', '\f', 'M', '\r', 
		'O', '\xE', 'Q', '\xF', 'S', '\x10', 'U', '\x11', 'W', '\x12', 'Y', '\x2', 
		'[', '\x13', ']', '\x2', '_', '\x2', '\x61', '\x14', '\x63', '\x15', '\x65', 
		'\x2', '\x3', '\x2', ' ', '\x4', '\x2', '\x43', '\x43', '\x63', '\x63', 
		'\x4', '\x2', '\x44', '\x44', '\x64', '\x64', '\x4', '\x2', '\x45', '\x45', 
		'\x65', '\x65', '\x4', '\x2', '\x46', '\x46', '\x66', '\x66', '\x4', '\x2', 
		'G', 'G', 'g', 'g', '\x4', '\x2', 'H', 'H', 'h', 'h', '\x4', '\x2', 'I', 
		'I', 'i', 'i', '\x4', '\x2', 'J', 'J', 'j', 'j', '\x4', '\x2', 'K', 'K', 
		'k', 'k', '\x4', '\x2', 'L', 'L', 'l', 'l', '\x4', '\x2', 'M', 'M', 'm', 
		'm', '\x4', '\x2', 'N', 'N', 'n', 'n', '\x4', '\x2', 'O', 'O', 'o', 'o', 
		'\x4', '\x2', 'P', 'P', 'p', 'p', '\x4', '\x2', 'Q', 'Q', 'q', 'q', '\x4', 
		'\x2', 'R', 'R', 'r', 'r', '\x4', '\x2', 'S', 'S', 's', 's', '\x4', '\x2', 
		'T', 'T', 't', 't', '\x4', '\x2', 'U', 'U', 'u', 'u', '\x4', '\x2', 'V', 
		'V', 'v', 'v', '\x4', '\x2', 'W', 'W', 'w', 'w', '\x4', '\x2', 'X', 'X', 
		'x', 'x', '\x4', '\x2', 'Y', 'Y', 'y', 'y', '\x4', '\x2', 'Z', 'Z', 'z', 
		'z', '\x4', '\x2', '[', '[', '{', '{', '\x4', '\x2', '\\', '\\', '|', 
		'|', '\x6', '\x2', '\v', '\f', '\xF', '\xF', '$', '$', '\x202A', '\x202B', 
		'\x3', '\x2', '\x32', ';', '\x4', '\x2', '>', '>', '@', '@', '\x5', '\x2', 
		'\v', '\f', '\xF', '\xF', '\"', '\"', '\x2', '\xFB', '\x2', '\x3', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x45', '\x3', '\x2', '\x2', '\x2', '\x2', 'G', '\x3', '\x2', 
		'\x2', '\x2', '\x2', 'I', '\x3', '\x2', '\x2', '\x2', '\x2', 'K', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'M', '\x3', '\x2', '\x2', '\x2', '\x2', 'O', 
		'\x3', '\x2', '\x2', '\x2', '\x2', 'Q', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'S', '\x3', '\x2', '\x2', '\x2', '\x2', 'U', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'W', '\x3', '\x2', '\x2', '\x2', '\x2', '[', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x61', '\x3', '\x2', '\x2', '\x2', '\x2', '\x63', '\x3', 
		'\x2', '\x2', '\x2', '\x3', 'g', '\x3', '\x2', '\x2', '\x2', '\x5', 'i', 
		'\x3', '\x2', '\x2', '\x2', '\a', 'k', '\x3', '\x2', '\x2', '\x2', '\t', 
		'm', '\x3', '\x2', '\x2', '\x2', '\v', 'o', '\x3', '\x2', '\x2', '\x2', 
		'\r', 'q', '\x3', '\x2', '\x2', '\x2', '\xF', 's', '\x3', '\x2', '\x2', 
		'\x2', '\x11', 'u', '\x3', '\x2', '\x2', '\x2', '\x13', 'w', '\x3', '\x2', 
		'\x2', '\x2', '\x15', 'y', '\x3', '\x2', '\x2', '\x2', '\x17', '{', '\x3', 
		'\x2', '\x2', '\x2', '\x19', '}', '\x3', '\x2', '\x2', '\x2', '\x1B', 
		'\x7F', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x81', '\x3', '\x2', '\x2', 
		'\x2', '\x1F', '\x83', '\x3', '\x2', '\x2', '\x2', '!', '\x85', '\x3', 
		'\x2', '\x2', '\x2', '#', '\x87', '\x3', '\x2', '\x2', '\x2', '%', '\x89', 
		'\x3', '\x2', '\x2', '\x2', '\'', '\x8B', '\x3', '\x2', '\x2', '\x2', 
		')', '\x8D', '\x3', '\x2', '\x2', '\x2', '+', '\x8F', '\x3', '\x2', '\x2', 
		'\x2', '-', '\x91', '\x3', '\x2', '\x2', '\x2', '/', '\x93', '\x3', '\x2', 
		'\x2', '\x2', '\x31', '\x95', '\x3', '\x2', '\x2', '\x2', '\x33', '\x97', 
		'\x3', '\x2', '\x2', '\x2', '\x35', '\x99', '\x3', '\x2', '\x2', '\x2', 
		'\x37', '\x9B', '\x3', '\x2', '\x2', '\x2', '\x39', '\x9D', '\x3', '\x2', 
		'\x2', '\x2', ';', '\x9F', '\x3', '\x2', '\x2', '\x2', '=', '\xA1', '\x3', 
		'\x2', '\x2', '\x2', '?', '\xA3', '\x3', '\x2', '\x2', '\x2', '\x41', 
		'\xA5', '\x3', '\x2', '\x2', '\x2', '\x43', '\xAA', '\x3', '\x2', '\x2', 
		'\x2', '\x45', '\xAC', '\x3', '\x2', '\x2', '\x2', 'G', '\xB5', '\x3', 
		'\x2', '\x2', '\x2', 'I', '\xBC', '\x3', '\x2', '\x2', '\x2', 'K', '\xC1', 
		'\x3', '\x2', '\x2', '\x2', 'M', '\xC7', '\x3', '\x2', '\x2', '\x2', 'O', 
		'\xCC', '\x3', '\x2', '\x2', '\x2', 'Q', '\xD0', '\x3', '\x2', '\x2', 
		'\x2', 'S', '\xD3', '\x3', '\x2', '\x2', '\x2', 'U', '\xE1', '\x3', '\x2', 
		'\x2', '\x2', 'W', '\xE3', '\x3', '\x2', '\x2', '\x2', 'Y', '\xE9', '\x3', 
		'\x2', '\x2', '\x2', '[', '\xF7', '\x3', '\x2', '\x2', '\x2', ']', '\x100', 
		'\x3', '\x2', '\x2', '\x2', '_', '\x102', '\x3', '\x2', '\x2', '\x2', 
		'\x61', '\x106', '\x3', '\x2', '\x2', '\x2', '\x63', '\x10A', '\x3', '\x2', 
		'\x2', '\x2', '\x65', '\x10E', '\x3', '\x2', '\x2', '\x2', 'g', 'h', '\a', 
		'.', '\x2', '\x2', 'h', '\x4', '\x3', '\x2', '\x2', '\x2', 'i', 'j', '\a', 
		',', '\x2', '\x2', 'j', '\x6', '\x3', '\x2', '\x2', '\x2', 'k', 'l', '\a', 
		'=', '\x2', '\x2', 'l', '\b', '\x3', '\x2', '\x2', '\x2', 'm', 'n', '\a', 
		'\x30', '\x2', '\x2', 'n', '\n', '\x3', '\x2', '\x2', '\x2', 'o', 'p', 
		'\a', '*', '\x2', '\x2', 'p', '\f', '\x3', '\x2', '\x2', '\x2', 'q', 'r', 
		'\a', '+', '\x2', '\x2', 'r', '\xE', '\x3', '\x2', '\x2', '\x2', 's', 
		't', '\t', '\x2', '\x2', '\x2', 't', '\x10', '\x3', '\x2', '\x2', '\x2', 
		'u', 'v', '\t', '\x3', '\x2', '\x2', 'v', '\x12', '\x3', '\x2', '\x2', 
		'\x2', 'w', 'x', '\t', '\x4', '\x2', '\x2', 'x', '\x14', '\x3', '\x2', 
		'\x2', '\x2', 'y', 'z', '\t', '\x5', '\x2', '\x2', 'z', '\x16', '\x3', 
		'\x2', '\x2', '\x2', '{', '|', '\t', '\x6', '\x2', '\x2', '|', '\x18', 
		'\x3', '\x2', '\x2', '\x2', '}', '~', '\t', '\a', '\x2', '\x2', '~', '\x1A', 
		'\x3', '\x2', '\x2', '\x2', '\x7F', '\x80', '\t', '\b', '\x2', '\x2', 
		'\x80', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x81', '\x82', '\t', '\t', 
		'\x2', '\x2', '\x82', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x83', '\x84', 
		'\t', '\n', '\x2', '\x2', '\x84', ' ', '\x3', '\x2', '\x2', '\x2', '\x85', 
		'\x86', '\t', '\v', '\x2', '\x2', '\x86', '\"', '\x3', '\x2', '\x2', '\x2', 
		'\x87', '\x88', '\t', '\f', '\x2', '\x2', '\x88', '$', '\x3', '\x2', '\x2', 
		'\x2', '\x89', '\x8A', '\t', '\r', '\x2', '\x2', '\x8A', '&', '\x3', '\x2', 
		'\x2', '\x2', '\x8B', '\x8C', '\t', '\xE', '\x2', '\x2', '\x8C', '(', 
		'\x3', '\x2', '\x2', '\x2', '\x8D', '\x8E', '\t', '\xF', '\x2', '\x2', 
		'\x8E', '*', '\x3', '\x2', '\x2', '\x2', '\x8F', '\x90', '\t', '\x10', 
		'\x2', '\x2', '\x90', ',', '\x3', '\x2', '\x2', '\x2', '\x91', '\x92', 
		'\t', '\x11', '\x2', '\x2', '\x92', '.', '\x3', '\x2', '\x2', '\x2', '\x93', 
		'\x94', '\t', '\x12', '\x2', '\x2', '\x94', '\x30', '\x3', '\x2', '\x2', 
		'\x2', '\x95', '\x96', '\t', '\x13', '\x2', '\x2', '\x96', '\x32', '\x3', 
		'\x2', '\x2', '\x2', '\x97', '\x98', '\t', '\x14', '\x2', '\x2', '\x98', 
		'\x34', '\x3', '\x2', '\x2', '\x2', '\x99', '\x9A', '\t', '\x15', '\x2', 
		'\x2', '\x9A', '\x36', '\x3', '\x2', '\x2', '\x2', '\x9B', '\x9C', '\t', 
		'\x16', '\x2', '\x2', '\x9C', '\x38', '\x3', '\x2', '\x2', '\x2', '\x9D', 
		'\x9E', '\t', '\x17', '\x2', '\x2', '\x9E', ':', '\x3', '\x2', '\x2', 
		'\x2', '\x9F', '\xA0', '\t', '\x18', '\x2', '\x2', '\xA0', '<', '\x3', 
		'\x2', '\x2', '\x2', '\xA1', '\xA2', '\t', '\x19', '\x2', '\x2', '\xA2', 
		'>', '\x3', '\x2', '\x2', '\x2', '\xA3', '\xA4', '\t', '\x1A', '\x2', 
		'\x2', '\xA4', '@', '\x3', '\x2', '\x2', '\x2', '\xA5', '\xA6', '\t', 
		'\x1B', '\x2', '\x2', '\xA6', '\x42', '\x3', '\x2', '\x2', '\x2', '\xA7', 
		'\xAB', '\n', '\x1C', '\x2', '\x2', '\xA8', '\xA9', '\a', '^', '\x2', 
		'\x2', '\xA9', '\xAB', '\a', '$', '\x2', '\x2', '\xAA', '\xA7', '\x3', 
		'\x2', '\x2', '\x2', '\xAA', '\xA8', '\x3', '\x2', '\x2', '\x2', '\xAB', 
		'\x44', '\x3', '\x2', '\x2', '\x2', '\xAC', '\xB0', '\a', '$', '\x2', 
		'\x2', '\xAD', '\xAF', '\x5', '\x43', '\"', '\x2', '\xAE', '\xAD', '\x3', 
		'\x2', '\x2', '\x2', '\xAF', '\xB2', '\x3', '\x2', '\x2', '\x2', '\xB0', 
		'\xAE', '\x3', '\x2', '\x2', '\x2', '\xB0', '\xB1', '\x3', '\x2', '\x2', 
		'\x2', '\xB1', '\xB3', '\x3', '\x2', '\x2', '\x2', '\xB2', '\xB0', '\x3', 
		'\x2', '\x2', '\x2', '\xB3', '\xB4', '\a', '$', '\x2', '\x2', '\xB4', 
		'\x46', '\x3', '\x2', '\x2', '\x2', '\xB5', '\xB6', '\x5', '\x33', '\x1A', 
		'\x2', '\xB6', '\xB7', '\x5', '\x17', '\f', '\x2', '\xB7', '\xB8', '\x5', 
		'%', '\x13', '\x2', '\xB8', '\xB9', '\x5', '\x17', '\f', '\x2', '\xB9', 
		'\xBA', '\x5', '\x13', '\n', '\x2', '\xBA', '\xBB', '\x5', '\x35', '\x1B', 
		'\x2', '\xBB', 'H', '\x3', '\x2', '\x2', '\x2', '\xBC', '\xBD', '\x5', 
		'\x19', '\r', '\x2', '\xBD', '\xBE', '\x5', '\x31', '\x19', '\x2', '\xBE', 
		'\xBF', '\x5', '+', '\x16', '\x2', '\xBF', '\xC0', '\x5', '\'', '\x14', 
		'\x2', '\xC0', 'J', '\x3', '\x2', '\x2', '\x2', '\xC1', '\xC2', '\x5', 
		';', '\x1E', '\x2', '\xC2', '\xC3', '\x5', '\x1D', '\xF', '\x2', '\xC3', 
		'\xC4', '\x5', '\x17', '\f', '\x2', '\xC4', '\xC5', '\x5', '\x31', '\x19', 
		'\x2', '\xC5', '\xC6', '\x5', '\x17', '\f', '\x2', '\xC6', 'L', '\x3', 
		'\x2', '\x2', '\x2', '\xC7', '\xC8', '\x5', '\x35', '\x1B', '\x2', '\xC8', 
		'\xC9', '\x5', '+', '\x16', '\x2', '\xC9', '\xCA', '\x5', '-', '\x17', 
		'\x2', '\xCA', 'N', '\x3', '\x2', '\x2', '\x2', '\xCB', '\xCD', '\t', 
		'\x1D', '\x2', '\x2', '\xCC', '\xCB', '\x3', '\x2', '\x2', '\x2', '\xCD', 
		'\xCE', '\x3', '\x2', '\x2', '\x2', '\xCE', '\xCC', '\x3', '\x2', '\x2', 
		'\x2', '\xCE', '\xCF', '\x3', '\x2', '\x2', '\x2', '\xCF', 'P', '\x3', 
		'\x2', '\x2', '\x2', '\xD0', '\xD1', '\x5', '\xF', '\b', '\x2', '\xD1', 
		'\xD2', '\x5', '\x33', '\x1A', '\x2', '\xD2', 'R', '\x3', '\x2', '\x2', 
		'\x2', '\xD3', '\xD4', '\x5', '\x33', '\x1A', '\x2', '\xD4', '\xD5', '\x5', 
		'+', '\x16', '\x2', '\xD5', '\xD6', '\x5', '\x31', '\x19', '\x2', '\xD6', 
		'\xD7', '\x5', '\x35', '\x1B', '\x2', '\xD7', 'T', '\x3', '\x2', '\x2', 
		'\x2', '\xD8', '\xD9', '\x5', '\xF', '\b', '\x2', '\xD9', '\xDA', '\x5', 
		'\x33', '\x1A', '\x2', '\xDA', '\xDB', '\x5', '\x13', '\n', '\x2', '\xDB', 
		'\xE2', '\x3', '\x2', '\x2', '\x2', '\xDC', '\xDD', '\x5', '\x15', '\v', 
		'\x2', '\xDD', '\xDE', '\x5', '\x17', '\f', '\x2', '\xDE', '\xDF', '\x5', 
		'\x33', '\x1A', '\x2', '\xDF', '\xE0', '\x5', '\x13', '\n', '\x2', '\xE0', 
		'\xE2', '\x3', '\x2', '\x2', '\x2', '\xE1', '\xD8', '\x3', '\x2', '\x2', 
		'\x2', '\xE1', '\xDC', '\x3', '\x2', '\x2', '\x2', '\xE2', 'V', '\x3', 
		'\x2', '\x2', '\x2', '\xE3', '\xE4', '\x5', '\x1B', '\xE', '\x2', '\xE4', 
		'\xE5', '\x5', '\x31', '\x19', '\x2', '\xE5', '\xE6', '\x5', '+', '\x16', 
		'\x2', '\xE6', '\xE7', '\x5', '\x37', '\x1C', '\x2', '\xE7', '\xE8', '\x5', 
		'-', '\x17', '\x2', '\xE8', 'X', '\x3', '\x2', '\x2', '\x2', '\xE9', '\xEA', 
		'\x5', '%', '\x13', '\x2', '\xEA', '\xEB', '\x5', '\x1F', '\x10', '\x2', 
		'\xEB', '\xEC', '\x5', '#', '\x12', '\x2', '\xEC', '\xED', '\x5', '\x17', 
		'\f', '\x2', '\xED', 'Z', '\x3', '\x2', '\x2', '\x2', '\xEE', '\xF8', 
		'\t', '\x1E', '\x2', '\x2', '\xEF', '\xF0', '\a', '#', '\x2', '\x2', '\xF0', 
		'\xF8', '\a', '?', '\x2', '\x2', '\xF1', '\xF8', '\a', '?', '\x2', '\x2', 
		'\xF2', '\xF3', '\a', '@', '\x2', '\x2', '\xF3', '\xF8', '\a', '?', '\x2', 
		'\x2', '\xF4', '\xF5', '\a', '>', '\x2', '\x2', '\xF5', '\xF8', '\a', 
		'?', '\x2', '\x2', '\xF6', '\xF8', '\x5', 'Y', '-', '\x2', '\xF7', '\xEE', 
		'\x3', '\x2', '\x2', '\x2', '\xF7', '\xEF', '\x3', '\x2', '\x2', '\x2', 
		'\xF7', '\xF1', '\x3', '\x2', '\x2', '\x2', '\xF7', '\xF2', '\x3', '\x2', 
		'\x2', '\x2', '\xF7', '\xF4', '\x3', '\x2', '\x2', '\x2', '\xF7', '\xF6', 
		'\x3', '\x2', '\x2', '\x2', '\xF8', '\\', '\x3', '\x2', '\x2', '\x2', 
		'\xF9', '\xFA', '\x5', '\xF', '\b', '\x2', '\xFA', '\xFB', '\x5', ')', 
		'\x15', '\x2', '\xFB', '\xFC', '\x5', '\x15', '\v', '\x2', '\xFC', '\x101', 
		'\x3', '\x2', '\x2', '\x2', '\xFD', '\xFE', '\x5', '+', '\x16', '\x2', 
		'\xFE', '\xFF', '\x5', '\x31', '\x19', '\x2', '\xFF', '\x101', '\x3', 
		'\x2', '\x2', '\x2', '\x100', '\xF9', '\x3', '\x2', '\x2', '\x2', '\x100', 
		'\xFD', '\x3', '\x2', '\x2', '\x2', '\x101', '^', '\x3', '\x2', '\x2', 
		'\x2', '\x102', '\x103', '\x5', ')', '\x15', '\x2', '\x103', '\x104', 
		'\x5', '+', '\x16', '\x2', '\x104', '\x105', '\x5', '\x35', '\x1B', '\x2', 
		'\x105', '`', '\x3', '\x2', '\x2', '\x2', '\x106', '\x108', '\x5', ']', 
		'/', '\x2', '\x107', '\x109', '\x5', '_', '\x30', '\x2', '\x108', '\x107', 
		'\x3', '\x2', '\x2', '\x2', '\x108', '\x109', '\x3', '\x2', '\x2', '\x2', 
		'\x109', '\x62', '\x3', '\x2', '\x2', '\x2', '\x10A', '\x10B', '\x5', 
		'\x65', '\x33', '\x2', '\x10B', '\x10C', '\x3', '\x2', '\x2', '\x2', '\x10C', 
		'\x10D', '\b', '\x32', '\x2', '\x2', '\x10D', '\x64', '\x3', '\x2', '\x2', 
		'\x2', '\x10E', '\x10F', '\t', '\x1F', '\x2', '\x2', '\x10F', '\x66', 
		'\x3', '\x2', '\x2', '\x2', '\n', '\x2', '\xAA', '\xB0', '\xCE', '\xE1', 
		'\xF7', '\x100', '\x108', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
