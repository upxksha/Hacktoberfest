from array import *
from ast import arguments
x=array('I',[1,2,2,4,5,6])
print (x[0:4])
x.append(7) 
x.extend([8,9])
print (x[0:-2])
x.insert(2,3)
print (x[0:-2])

for i in range(len(x)):
    print (x[i])
