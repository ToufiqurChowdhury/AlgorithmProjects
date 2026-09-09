class MyString:

    def __init__(self, val=None):
        if val == None:
            val = []

        self.value = val
        self.length = len(self.value)

    def split(self) -> list[MyString]:
        output = []
        s = self.value
        slen = self.length
        l = 0
        while l<slen:
            i = l
            while i < slen and s[i] == " ":
                i += 1

            j = i
            while j<slen and s[j] != " ":
                j += 1
            
            if i<j:
                output.append(MyString(s[i:j]))
    
            l = j
        
        return output

    def concat(self, s:MyString) -> MyString:

        s1 = self.value
        chararray = []

        for ch in s1:
            chararray.append(ch)

        for ch in s.value:
            chararray.append(ch)

        return MyString(chararray)


    def len(self) -> int:
        return self.length
    
    def trim(self) -> MyString:
        s = self.value
        slen= self.length

        i = 0
        while i < slen and s[i] == " ":
            i += 1
        
        j = slen-1
        while j >= i and s[j] == " ":
            j -= 1
                
        chararray =[]
        
        for k in range(i, j+1):
            chararray.append(s[k])
        
        return MyString(chararray)

    def equals(self, s:MyString) -> bool:
        if self.length != s.length:
            return False

        for i in range(s.length):
            if self.value[i] != s.value[i]:
                return False
        
        return True
    
    def upper(self) -> MyString:
        chararray = []
        for ch in self.value:
            if 'a' <= ch <= 'z':
                ch = chr(ord(ch)- 32)
            chararray.append(ch)

        return MyString(chararray)          


    def lower(self) -> MyString:
        chararray = []
        for ch in self.value:
            if 'A' <= ch <= 'Z':
                ch = chr(ord(ch) + 32)
            chararray.append(ch)

        return MyString(chararray)          
