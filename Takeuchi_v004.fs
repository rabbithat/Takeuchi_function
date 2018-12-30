\ Takeuchi function benchmark
\ ----------------------------------------------------------------------------------------
\
\ Lisp definition of Takeuchi function (Copied from: http://www.ulisp.com/show?1EO1):
\ (defun tak (x y z)
\   (if (not (< y x))
\      z
\     (tak
\      (tak (1- x) y z)
\      (tak (1- y) z x)
\      (tak (1- z) x y))))
	 
\ ----------------------------------------------------------------------------------------
\ Equivalent Forth definition of Takeuchi function:
	 
\ ( x y z -- x y z boolean)
: not_y<x?  1 pick 3 pick >= ;

\ ( x y z -- z )
: only_z swap drop swap drop ;

\ ( x y z -- x y z x-1 y z)	 
: takx 2 pick 1- 2 pick 2 pick ;

\ ( x y z result1 -- x y z result1 y-1 z x)
: taky 2 pick 1- 2 pick 5 pick ;

\ ( x y z result1 result2 -- result1 result2 (z-1) x y)
: takz rot 1- 0 2rot rot drop ;

\ ( x y z -- result )
\ : tak not_y<x? if only_z else takx recurse taky recurse takz recurse recurse then ;

\ This will be hard to read, but I manually inlined the above definitions
\ ( x y z -- result )
: tak 1 pick 3 pick >= if swap drop swap drop else 2 pick 1- 2 pick 2 pick recurse 2 pick 1- 2 pick 5 pick recurse rot 1- 0 2rot rot drop recurse recurse then ;

\ code to measure total execution time of tak 
: tk CR initializeRtc startRtc tak NRF_RTC__COUNTER @ 315 * 10000 / . ." ms." CR ;


