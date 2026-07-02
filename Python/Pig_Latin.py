
# Returns true if the given character is an English vowel
def is_vowel(char):
  vowels = ['a', 'e', 'i', 'o', 'u']
  return char.lower() in vowels

# Pig Latin algorithm
words = ["peanut", "butter", "and", "jelly"]
for i in range(0, len(words)):
  word = words[i]
  word += "-";
  first_letter = word[0]
  if is_vowel(first_letter):
    word += "yay"
  else:
    word += first_letter
    word += "ay"
    word = word[1:]
  words[i] = word

# Display magnificent result
print(words)
