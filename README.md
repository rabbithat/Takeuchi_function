# Takeuchi_function
Used in benchmarking uLisp.  Here translated to mecrisp-stellaris Forth RA for a comparison benchmark.


On an nRF52840 runnning uLisp, the Takeuchi-function
(tak 18 12 6)
executes in 8,102 milliseconds (http://forum.ulisp.com/t/how-can-i-get-ulisp-to-run-on-a-nordic-nrf52840/239/15).

On an nRF52840 running mecrisp-stellaris Forth RA, the same function with the same numbers executes in 134 milliseconds.  Put another way, the same function operating on the same numbers takes more than 60x longer to execute on uLisp than on ms-Forth RA.

For version 2, I re-wrote the Takeuchi function so as not to use the roll word.  This reduced execution time on MS-Forth 2.4.7 RA to 102ms.  This also allowed me to try running it on MS-Forth 2.4.6 (the non-RA version), and it executed in 132ms.  So, although not a perfect comparison, this appears to demonstrate that the RA version does indeed run faster.

So, with version 2, MS-Forth 2.4.7 RA runs the Takeuchi benchmark nearly 80x faster than uLisp does.
