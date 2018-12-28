# Takeuchi_function
Used in benchmarking uLisp.  Here translated to mecrisp-stellaris Forth for a comparison benchmark


On an nRF52840 runnning uLisp, the Takeuchi-function
(tak 18 12 6)
executes in 8,102 milliseconds (http://forum.ulisp.com/t/how-can-i-get-ulisp-to-run-on-a-nordic-nrf52840/239/15)

On an nRF52840 running mecrisp-stellaris Forth RA, the same function with the same numbers executes in 134 milliseconds.  Put another way, the same function operating on the same numbers takes more than 60x longer to execute on uLisp than on ms-Forth RA.
