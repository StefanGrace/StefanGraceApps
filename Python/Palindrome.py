# Palindrome.py
# Stefan Grace
# Created: 2017-06-15
# Modified: 2017-06-15
# This program says if the input is the same read backwards and forwards

word = input("Enter a word: ")
word = str.lower(word)
matches = 0
loop_count = len(word)
letter = loop_count - 1
loop_count_original = loop_count
while loop_count > 0:
    if word[int(letter)]==word[int((len(word)-1)-letter)]:
        matches = matches + 1
    letter = letter - 1
    loop_count = loop_count - 1   
if loop_count_original == matches:
    print (word+" is a palindrome")
else:
    print (word+" is not a palindrome")
