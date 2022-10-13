#Tip Calculator

print("Tip Calculator")

billamount= float(input("Enter your bill amount : "))
tip= float(input("what percentage of tip you want to give?\n"))
x= (billamount + (0.01*tip)*billamount)
print("Customer has to pay : ",x)
