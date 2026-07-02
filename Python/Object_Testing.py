# Object_Testing.py
# Stefan Grace
# 2018-09-10

class MyClass:
    def __init__(self, var1, var2):
        self.var1 = var1
        self.var2 = var2
    def getVar1(self):
        return self.var1
myObject = MyClass(85, 42)
print(myObject.getVar1())
