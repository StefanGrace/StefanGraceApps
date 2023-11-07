# Typing_Test.py
# Stefan Grace
# Created: 2017-06-18
# Modified: 2019-01-05

def wpm():
    duration = end-start
    wordsPerMin = len(typing.split())/(duration/60)
    return wordsPerMin
    
def accuracy():
    correctLetters = 0
    if len(TEXT)>len(typing):
        loopCount = len(typing)
    else:
        loopCount = len(TEXT)
    while loopCount>0:
        if TEXT[loopCount-1]==typing[loopCount-1]:
            correctLetters = correctLetters+1
        loopCount = loopCount-1
    decimal = correctLetters/len(TEXT)
    percentage = decimal*100
    return percentage

# Main routine
import time
TEXT = "the quick brown fox jumps over the lazy dog"
print("Typing Speed Test")
print("Press Enter, then type the following text below, then press Enter")
input(TEXT)
start = time.time()
typing = input().lower()
end = time.time()
print("Words Per Minute: "+str(int(wpm())))
print("Accuracy: "+str(int(accuracy()))+"%")



