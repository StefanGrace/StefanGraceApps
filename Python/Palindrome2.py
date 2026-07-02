class Palindrome:

    @staticmethod
    def is_palindrome(word):
        word_lower = word.lower()
        same_letter = 0
        for i in range(0,len(word_lower)):
            if (word_lower[i]==word_lower[len(word_lower)-1-i]):
                same_letter += 1
        if (same_letter==len(word_lower)):
            return True
        else:
            return False

print(Palindrome.is_palindrome('Deleveled'))
