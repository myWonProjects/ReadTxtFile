# ReadTxtFile


With this project, we can read any txt extension file and and print all lines in the file. For this we use "ReadAllLines" method and all lines we read put in an array. But we also want to insert a line that we define a string value in advance, so we are able to do this with if block and "Equals" method. 
We made this in try-catch block, in this way we can debug more easily and also the message we want to will be displayed regardless of error type.


This approach will read the entire file into memory. So this has a few issues with performans. If the flie is large, it will use a lot of memory. In addition, this method fixes many efficiency issues, but we still keep all file contents in memory. It is the best terms of memory usage because you don't keep all file contents as a single string or buffer. 


But we should keep 3 things in mind:

1. Premature optimization" may be often wasted effort.There's a chance that the performance of that part of your code isn't really important.
2. What we're trying to do doesn't scale. If it is large, the doesn't enough. (IOException)
3. File may not exist or pathname may be too long. (PathTooLongException)


