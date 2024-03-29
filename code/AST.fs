// Tim Forth & Eric Gage c. 2023
module AST

type Box =
| ThreeFour
| FourThree
type Coverage =
| Cover1
| Cover2
type Defense = Box * Coverage

type Player =
| X
| Y
| Z
| H
| A
type Movement =
| Go
| Slant
| Out
| In
| Post
| Corner
| Curl
| Comeback
| Block
| Screen
| Run
type Read =
| First
| Second
| Third
| Fourth
| Fifth
type Route = Player * Movement * Read
type Routes =  Route list

type Scheme =
| Power
| Counter
| InsideZone
| OutsideZone
| Pass

type Receivers =
| NoReceivers
| YesReceivers of char * char
type Unit =
| Under
| Shotgun
type Formation = Unit * Receivers


type Play = Defense * Scheme * Routes * Formation
let CANVAS_SZ = 1500