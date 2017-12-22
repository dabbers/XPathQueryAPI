
grammar htmlapi;

/**************
 *
 *  BEGIN TOKENIZER
 *
 *************/

// Our keywords can be any case (SeLECt).
fragment A:('a'|'A');
fragment B:('b'|'B');
fragment C:('c'|'C');
fragment D:('d'|'D');
fragment E:('e'|'E');
fragment F:('f'|'F');
fragment G:('g'|'G');
fragment H:('h'|'H');
fragment I:('i'|'I');
fragment J:('j'|'J');
fragment K:('k'|'K');
fragment L:('l'|'L');
fragment M:('m'|'M');
fragment N:('n'|'N');
fragment O:('o'|'O');
fragment P:('p'|'P');
fragment Q:('q'|'Q');
fragment R:('r'|'R');
fragment S:('s'|'S');
fragment T:('t'|'T');
fragment U:('u'|'U');
fragment V:('v'|'V');
fragment W:('w'|'W');
fragment X:('x'|'X');
fragment Y:('y'|'Y');
fragment Z:('z'|'Z');


fragment VALUE_CHAR
    :
        ~(["\n\r\u2028\u2029\t])
    |
        '\\"'
    ;

VALUE_STRING
    :
        '"' VALUE_CHAR* '"'
    ;

SELECT
    :
        S E L E C T
    ;

FROM
    :
        F R O M
    ;

WHERE
    :
        W H E R E
    ;

TOP
    :
       T O P
    ;
INTEGER
    :
        [0-9]+
    ;

AS
    :
        A S
    ;

SORT
    :
        S O R T
    ;

SORT_TYPE
    :
        (A S C|D E S C)
    ;
GROUP
    :
        G R O U P
    ;

fragment LIKE
    :
        L I K E
    ;

COMPARE_OPERATORS
    :
        ( '<' | '>' | '!=' | '=' | '>=' | '<=' | LIKE )
    ;

fragment AND_OR
    :
        A N D | O R
    ;

fragment NEGATE
    :
        N O T
    ;

LOGIC_OPERATIONS
    :
        AND_OR NEGATE?
    ;

WS
    :
        WHITESPACE -> skip
    ;

fragment WHITESPACE
    :
        ( ' ' | '\t' | '\r' | '\n' )
    ;

/**************
 *
 *  BEGIN PARSER
 *
 *************/
 
// Beginning
query
    :
        singleQuery+
    ;

singleQuery
    :
        SELECT

        (TOP INTEGER)?

        (columnIdentifier (',' columnIdentifier)* |'*')

        FROM

        columnIdentifier

        whereFilter?

        sortFilter?

        ';'
    ;

columnIdentifier
    :
        VALUE_STRING ('.' VALUE_STRING)* (AS VALUE_STRING)?
    ;

whereFilter
    :
        WHERE
            whereBody
    ;

whereBody
    :
        '('
            whereBody        
        ')'
    |
        columnIdentifier
        COMPARE_OPERATORS
        (columnIdentifier|columnIdentifier)

        (
            LOGIC_OPERATIONS 
            whereBody
        )?
    ;

sortFilter
    :
        SORT 
            columnIdentifier SORT_TYPE
            (',' columnIdentifier SORT_TYPE)*
    ;
