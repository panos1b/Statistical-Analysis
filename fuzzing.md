## Answers to Lab Exercise 3 Part 2 - SeiP 2024
Name : Panagiotis Daskalopoulos

### Task 1 (exercise1)
Answer: The program failed when the string which was entered was `^j  t^j^j^j^j^j^j^j^j^j^j ^pT  wJ  J^n^Wl -j ^N  ^HY s 4  ^r5Q|` and seems to have to do with the two numbers which were encountered in the string. This functionality might not be expected and is traced back to the fact that line 28 is inside of the if statement on line 24. Therefore, consecutive numbers in any position will cause a crash

### Task 2 (exercise2)
Answer: The program failed for input `ffl ^et^d^}^f` this makes sense as both crew members are fired and then the plane tries to take off causing the abort() function to get run. The same for ``S ^ettttf~flfS  % ^`^@^d^gy`` and `^effffS  % ^mt^b^}^f% ^mt^b^}^fhhh^nfd ll hhh^nfd ^tl`. The issue arises from the number of firings before another operation takes place. 

### Task 3 (exercise4)
Answer: Comparing to exersise2 but without having access to the source code we see that yet again crashes occur when the input contains multiple firings before handling another operation.
Some fuzzed inputs that failed and match such criteria are:
- `llllllllffffllqqlll S  h^f{^_ Ot^X ^_A S  h^f{^_^H` 
- `tttt^@ llllffff^Qt^h > tt^k^k^k^ktttttattttt{tttt^@ lllllllllllllbmlltt` 
- `^Wtv >j^|  OA^FVf^O^r   ffffff^Wtv >j^|  Otttttttttt >j^k hhh^Okllllq _j^|  OA^FVf ^r^r   {L^l tvq`
- `^Wtv >fff^O^r  1{L^l  ^W^W^WVf^O^rlllllq`

But experimenting with the binary we find that the previous input `ffl ^et^d^}^f` does not in fact crash this binary. This makes me believe that the only difference between the source code of the two exercises is the fact that the flight crew needed to fly the bigger aircraft is four instead of two. This is consistent with our fizzers results (as at least four `f` appear before the operations) and our own testing.

_Note: QEMU mode was used to fuzz the binary only target_
