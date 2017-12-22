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
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class htmlapiParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, VALUE_STRING=7, SELECT=8, 
		FROM=9, WHERE=10, TOP=11, INTEGER=12, AS=13, SORT=14, SORT_TYPE=15, GROUP=16, 
		COMPARE_OPERATORS=17, LOGIC_OPERATIONS=18, WS=19;
	public const int
		RULE_query = 0, RULE_singleQuery = 1, RULE_columnIdentifier = 2, RULE_whereFilter = 3, 
		RULE_whereBody = 4, RULE_sortFilter = 5;
	public static readonly string[] ruleNames = {
		"query", "singleQuery", "columnIdentifier", "whereFilter", "whereBody", 
		"sortFilter"
	};

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

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static htmlapiParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public htmlapiParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public htmlapiParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}
	public partial class QueryContext : ParserRuleContext {
		public SingleQueryContext[] singleQuery() {
			return GetRuleContexts<SingleQueryContext>();
		}
		public SingleQueryContext singleQuery(int i) {
			return GetRuleContext<SingleQueryContext>(i);
		}
		public QueryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_query; } }
		public override void EnterRule(IParseTreeListener listener) {
			IhtmlapiListener typedListener = listener as IhtmlapiListener;
			if (typedListener != null) typedListener.EnterQuery(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IhtmlapiListener typedListener = listener as IhtmlapiListener;
			if (typedListener != null) typedListener.ExitQuery(this);
		}
	}

	[RuleVersion(0)]
	public QueryContext query() {
		QueryContext _localctx = new QueryContext(Context, State);
		EnterRule(_localctx, 0, RULE_query);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 13;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 12; singleQuery();
				}
				}
				State = 15;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==SELECT );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SingleQueryContext : ParserRuleContext {
		public ITerminalNode SELECT() { return GetToken(htmlapiParser.SELECT, 0); }
		public ITerminalNode FROM() { return GetToken(htmlapiParser.FROM, 0); }
		public ColumnIdentifierContext[] columnIdentifier() {
			return GetRuleContexts<ColumnIdentifierContext>();
		}
		public ColumnIdentifierContext columnIdentifier(int i) {
			return GetRuleContext<ColumnIdentifierContext>(i);
		}
		public ITerminalNode TOP() { return GetToken(htmlapiParser.TOP, 0); }
		public ITerminalNode INTEGER() { return GetToken(htmlapiParser.INTEGER, 0); }
		public WhereFilterContext whereFilter() {
			return GetRuleContext<WhereFilterContext>(0);
		}
		public SortFilterContext sortFilter() {
			return GetRuleContext<SortFilterContext>(0);
		}
		public SingleQueryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_singleQuery; } }
		public override void EnterRule(IParseTreeListener listener) {
			IhtmlapiListener typedListener = listener as IhtmlapiListener;
			if (typedListener != null) typedListener.EnterSingleQuery(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IhtmlapiListener typedListener = listener as IhtmlapiListener;
			if (typedListener != null) typedListener.ExitSingleQuery(this);
		}
	}

	[RuleVersion(0)]
	public SingleQueryContext singleQuery() {
		SingleQueryContext _localctx = new SingleQueryContext(Context, State);
		EnterRule(_localctx, 2, RULE_singleQuery);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 17; Match(SELECT);
			State = 20;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==TOP) {
				{
				State = 18; Match(TOP);
				State = 19; Match(INTEGER);
				}
			}

			State = 31;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case VALUE_STRING:
				{
				State = 22; columnIdentifier();
				State = 27;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==T__0) {
					{
					{
					State = 23; Match(T__0);
					State = 24; columnIdentifier();
					}
					}
					State = 29;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				}
				break;
			case T__1:
				{
				State = 30; Match(T__1);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 33; Match(FROM);
			State = 34; columnIdentifier();
			State = 36;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WHERE) {
				{
				State = 35; whereFilter();
				}
			}

			State = 39;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SORT) {
				{
				State = 38; sortFilter();
				}
			}

			State = 41; Match(T__2);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ColumnIdentifierContext : ParserRuleContext {
		public ITerminalNode[] VALUE_STRING() { return GetTokens(htmlapiParser.VALUE_STRING); }
		public ITerminalNode VALUE_STRING(int i) {
			return GetToken(htmlapiParser.VALUE_STRING, i);
		}
		public ITerminalNode AS() { return GetToken(htmlapiParser.AS, 0); }
		public ColumnIdentifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_columnIdentifier; } }
		public override void EnterRule(IParseTreeListener listener) {
			IhtmlapiListener typedListener = listener as IhtmlapiListener;
			if (typedListener != null) typedListener.EnterColumnIdentifier(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IhtmlapiListener typedListener = listener as IhtmlapiListener;
			if (typedListener != null) typedListener.ExitColumnIdentifier(this);
		}
	}

	[RuleVersion(0)]
	public ColumnIdentifierContext columnIdentifier() {
		ColumnIdentifierContext _localctx = new ColumnIdentifierContext(Context, State);
		EnterRule(_localctx, 4, RULE_columnIdentifier);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 43; Match(VALUE_STRING);
			State = 48;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==T__3) {
				{
				{
				State = 44; Match(T__3);
				State = 45; Match(VALUE_STRING);
				}
				}
				State = 50;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 53;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==AS) {
				{
				State = 51; Match(AS);
				State = 52; Match(VALUE_STRING);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WhereFilterContext : ParserRuleContext {
		public ITerminalNode WHERE() { return GetToken(htmlapiParser.WHERE, 0); }
		public WhereBodyContext whereBody() {
			return GetRuleContext<WhereBodyContext>(0);
		}
		public WhereFilterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_whereFilter; } }
		public override void EnterRule(IParseTreeListener listener) {
			IhtmlapiListener typedListener = listener as IhtmlapiListener;
			if (typedListener != null) typedListener.EnterWhereFilter(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IhtmlapiListener typedListener = listener as IhtmlapiListener;
			if (typedListener != null) typedListener.ExitWhereFilter(this);
		}
	}

	[RuleVersion(0)]
	public WhereFilterContext whereFilter() {
		WhereFilterContext _localctx = new WhereFilterContext(Context, State);
		EnterRule(_localctx, 6, RULE_whereFilter);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 55; Match(WHERE);
			State = 56; whereBody();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WhereBodyContext : ParserRuleContext {
		public WhereBodyContext whereBody() {
			return GetRuleContext<WhereBodyContext>(0);
		}
		public ColumnIdentifierContext[] columnIdentifier() {
			return GetRuleContexts<ColumnIdentifierContext>();
		}
		public ColumnIdentifierContext columnIdentifier(int i) {
			return GetRuleContext<ColumnIdentifierContext>(i);
		}
		public ITerminalNode COMPARE_OPERATORS() { return GetToken(htmlapiParser.COMPARE_OPERATORS, 0); }
		public ITerminalNode LOGIC_OPERATIONS() { return GetToken(htmlapiParser.LOGIC_OPERATIONS, 0); }
		public WhereBodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_whereBody; } }
		public override void EnterRule(IParseTreeListener listener) {
			IhtmlapiListener typedListener = listener as IhtmlapiListener;
			if (typedListener != null) typedListener.EnterWhereBody(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IhtmlapiListener typedListener = listener as IhtmlapiListener;
			if (typedListener != null) typedListener.ExitWhereBody(this);
		}
	}

	[RuleVersion(0)]
	public WhereBodyContext whereBody() {
		WhereBodyContext _localctx = new WhereBodyContext(Context, State);
		EnterRule(_localctx, 8, RULE_whereBody);
		int _la;
		try {
			State = 72;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__4:
				EnterOuterAlt(_localctx, 1);
				{
				State = 58; Match(T__4);
				State = 59; whereBody();
				State = 60; Match(T__5);
				}
				break;
			case VALUE_STRING:
				EnterOuterAlt(_localctx, 2);
				{
				State = 62; columnIdentifier();
				State = 63; Match(COMPARE_OPERATORS);
				State = 66;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,8,Context) ) {
				case 1:
					{
					State = 64; columnIdentifier();
					}
					break;
				case 2:
					{
					State = 65; columnIdentifier();
					}
					break;
				}
				State = 70;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LOGIC_OPERATIONS) {
					{
					State = 68; Match(LOGIC_OPERATIONS);
					State = 69; whereBody();
					}
				}

				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SortFilterContext : ParserRuleContext {
		public ITerminalNode SORT() { return GetToken(htmlapiParser.SORT, 0); }
		public ColumnIdentifierContext[] columnIdentifier() {
			return GetRuleContexts<ColumnIdentifierContext>();
		}
		public ColumnIdentifierContext columnIdentifier(int i) {
			return GetRuleContext<ColumnIdentifierContext>(i);
		}
		public ITerminalNode[] SORT_TYPE() { return GetTokens(htmlapiParser.SORT_TYPE); }
		public ITerminalNode SORT_TYPE(int i) {
			return GetToken(htmlapiParser.SORT_TYPE, i);
		}
		public SortFilterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_sortFilter; } }
		public override void EnterRule(IParseTreeListener listener) {
			IhtmlapiListener typedListener = listener as IhtmlapiListener;
			if (typedListener != null) typedListener.EnterSortFilter(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IhtmlapiListener typedListener = listener as IhtmlapiListener;
			if (typedListener != null) typedListener.ExitSortFilter(this);
		}
	}

	[RuleVersion(0)]
	public SortFilterContext sortFilter() {
		SortFilterContext _localctx = new SortFilterContext(Context, State);
		EnterRule(_localctx, 10, RULE_sortFilter);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 74; Match(SORT);
			State = 75; columnIdentifier();
			State = 76; Match(SORT_TYPE);
			State = 83;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==T__0) {
				{
				{
				State = 77; Match(T__0);
				State = 78; columnIdentifier();
				State = 79; Match(SORT_TYPE);
				}
				}
				State = 85;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x15', 'Y', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x3', '\x2', '\x6', '\x2', 
		'\x10', '\n', '\x2', '\r', '\x2', '\xE', '\x2', '\x11', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x5', '\x3', '\x17', '\n', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\a', '\x3', '\x1C', '\n', '\x3', '\f', 
		'\x3', '\xE', '\x3', '\x1F', '\v', '\x3', '\x3', '\x3', '\x5', '\x3', 
		'\"', '\n', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x5', '\x3', 
		'\'', '\n', '\x3', '\x3', '\x3', '\x5', '\x3', '*', '\n', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\a', '\x4', 
		'\x31', '\n', '\x4', '\f', '\x4', '\xE', '\x4', '\x34', '\v', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x5', '\x4', '\x38', '\n', '\x4', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x5', '\x6', '\x45', '\n', '\x6', '\x3', '\x6', '\x3', '\x6', '\x5', 
		'\x6', 'I', '\n', '\x6', '\x5', '\x6', 'K', '\n', '\x6', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\a', '\a', 'T', '\n', '\a', '\f', '\a', '\xE', '\a', 'W', '\v', 
		'\a', '\x3', '\a', '\x2', '\x2', '\b', '\x2', '\x4', '\x6', '\b', '\n', 
		'\f', '\x2', '\x2', '\x2', '^', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\x4', '\x13', '\x3', '\x2', '\x2', '\x2', '\x6', '-', '\x3', '\x2', '\x2', 
		'\x2', '\b', '\x39', '\x3', '\x2', '\x2', '\x2', '\n', 'J', '\x3', '\x2', 
		'\x2', '\x2', '\f', 'L', '\x3', '\x2', '\x2', '\x2', '\xE', '\x10', '\x5', 
		'\x4', '\x3', '\x2', '\xF', '\xE', '\x3', '\x2', '\x2', '\x2', '\x10', 
		'\x11', '\x3', '\x2', '\x2', '\x2', '\x11', '\xF', '\x3', '\x2', '\x2', 
		'\x2', '\x11', '\x12', '\x3', '\x2', '\x2', '\x2', '\x12', '\x3', '\x3', 
		'\x2', '\x2', '\x2', '\x13', '\x16', '\a', '\n', '\x2', '\x2', '\x14', 
		'\x15', '\a', '\r', '\x2', '\x2', '\x15', '\x17', '\a', '\xE', '\x2', 
		'\x2', '\x16', '\x14', '\x3', '\x2', '\x2', '\x2', '\x16', '\x17', '\x3', 
		'\x2', '\x2', '\x2', '\x17', '!', '\x3', '\x2', '\x2', '\x2', '\x18', 
		'\x1D', '\x5', '\x6', '\x4', '\x2', '\x19', '\x1A', '\a', '\x3', '\x2', 
		'\x2', '\x1A', '\x1C', '\x5', '\x6', '\x4', '\x2', '\x1B', '\x19', '\x3', 
		'\x2', '\x2', '\x2', '\x1C', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x1D', 
		'\x1B', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1E', '\x3', '\x2', '\x2', 
		'\x2', '\x1E', '\"', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x1D', '\x3', 
		'\x2', '\x2', '\x2', ' ', '\"', '\a', '\x4', '\x2', '\x2', '!', '\x18', 
		'\x3', '\x2', '\x2', '\x2', '!', ' ', '\x3', '\x2', '\x2', '\x2', '\"', 
		'#', '\x3', '\x2', '\x2', '\x2', '#', '$', '\a', '\v', '\x2', '\x2', '$', 
		'&', '\x5', '\x6', '\x4', '\x2', '%', '\'', '\x5', '\b', '\x5', '\x2', 
		'&', '%', '\x3', '\x2', '\x2', '\x2', '&', '\'', '\x3', '\x2', '\x2', 
		'\x2', '\'', ')', '\x3', '\x2', '\x2', '\x2', '(', '*', '\x5', '\f', '\a', 
		'\x2', ')', '(', '\x3', '\x2', '\x2', '\x2', ')', '*', '\x3', '\x2', '\x2', 
		'\x2', '*', '+', '\x3', '\x2', '\x2', '\x2', '+', ',', '\a', '\x5', '\x2', 
		'\x2', ',', '\x5', '\x3', '\x2', '\x2', '\x2', '-', '\x32', '\a', '\t', 
		'\x2', '\x2', '.', '/', '\a', '\x6', '\x2', '\x2', '/', '\x31', '\a', 
		'\t', '\x2', '\x2', '\x30', '.', '\x3', '\x2', '\x2', '\x2', '\x31', '\x34', 
		'\x3', '\x2', '\x2', '\x2', '\x32', '\x30', '\x3', '\x2', '\x2', '\x2', 
		'\x32', '\x33', '\x3', '\x2', '\x2', '\x2', '\x33', '\x37', '\x3', '\x2', 
		'\x2', '\x2', '\x34', '\x32', '\x3', '\x2', '\x2', '\x2', '\x35', '\x36', 
		'\a', '\xF', '\x2', '\x2', '\x36', '\x38', '\a', '\t', '\x2', '\x2', '\x37', 
		'\x35', '\x3', '\x2', '\x2', '\x2', '\x37', '\x38', '\x3', '\x2', '\x2', 
		'\x2', '\x38', '\a', '\x3', '\x2', '\x2', '\x2', '\x39', ':', '\a', '\f', 
		'\x2', '\x2', ':', ';', '\x5', '\n', '\x6', '\x2', ';', '\t', '\x3', '\x2', 
		'\x2', '\x2', '<', '=', '\a', '\a', '\x2', '\x2', '=', '>', '\x5', '\n', 
		'\x6', '\x2', '>', '?', '\a', '\b', '\x2', '\x2', '?', 'K', '\x3', '\x2', 
		'\x2', '\x2', '@', '\x41', '\x5', '\x6', '\x4', '\x2', '\x41', '\x44', 
		'\a', '\x13', '\x2', '\x2', '\x42', '\x45', '\x5', '\x6', '\x4', '\x2', 
		'\x43', '\x45', '\x5', '\x6', '\x4', '\x2', '\x44', '\x42', '\x3', '\x2', 
		'\x2', '\x2', '\x44', '\x43', '\x3', '\x2', '\x2', '\x2', '\x45', 'H', 
		'\x3', '\x2', '\x2', '\x2', '\x46', 'G', '\a', '\x14', '\x2', '\x2', 'G', 
		'I', '\x5', '\n', '\x6', '\x2', 'H', '\x46', '\x3', '\x2', '\x2', '\x2', 
		'H', 'I', '\x3', '\x2', '\x2', '\x2', 'I', 'K', '\x3', '\x2', '\x2', '\x2', 
		'J', '<', '\x3', '\x2', '\x2', '\x2', 'J', '@', '\x3', '\x2', '\x2', '\x2', 
		'K', '\v', '\x3', '\x2', '\x2', '\x2', 'L', 'M', '\a', '\x10', '\x2', 
		'\x2', 'M', 'N', '\x5', '\x6', '\x4', '\x2', 'N', 'U', '\a', '\x11', '\x2', 
		'\x2', 'O', 'P', '\a', '\x3', '\x2', '\x2', 'P', 'Q', '\x5', '\x6', '\x4', 
		'\x2', 'Q', 'R', '\a', '\x11', '\x2', '\x2', 'R', 'T', '\x3', '\x2', '\x2', 
		'\x2', 'S', 'O', '\x3', '\x2', '\x2', '\x2', 'T', 'W', '\x3', '\x2', '\x2', 
		'\x2', 'U', 'S', '\x3', '\x2', '\x2', '\x2', 'U', 'V', '\x3', '\x2', '\x2', 
		'\x2', 'V', '\r', '\x3', '\x2', '\x2', '\x2', 'W', 'U', '\x3', '\x2', 
		'\x2', '\x2', '\xE', '\x11', '\x16', '\x1D', '!', '&', ')', '\x32', '\x37', 
		'\x44', 'H', 'J', 'U',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
