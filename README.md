# Memory-allocation
Input:

1-user inputs memory size , fill the table of Hole size and its starting address then press on   APPLY button

2-user inputs number of processes

3- user input each process ID and its size . Example:( P1 300)

4-user chooses the method of allocation ( first fit - Best fit)

5-if its first time to input the process in the table choose (ALLOCATE)

6- check on the process to deallocate then press on DEALLOCATE button

7- to reallocate a process that already exists in the table but wasn't allocated because of its size,check next to it then press on REALLOCATE  button  after choosing the method of allocation (First fit - Best fit)

8- RESET button enables you from re-starting your program 

Output:

it outputs a memory layout with holes and allocated processes (size and starting address)

--> the layout appears in two tables  and Gantt chart 

Error detection:

1- If user inputs total number of holes  larger than memory size , an error message appears and you should RESET your program

2- If user asked to allocate a process with size larger than existing holes , an error message appears to notify him that the process won't be allocated and he has an option to deallocate any other  existing process then reallocate this one .

Desktop application
Used language:
C# with GUI
