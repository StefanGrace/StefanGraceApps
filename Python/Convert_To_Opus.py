# Convert_To_Opus.py
# Stefan Grace
# Created: 2020-11-17
# Modified: 2020-11-27
# Writes batch files to convert MP3, WAV and FLAC audio files to opus (.ogg)


import os

os.system("dir /b > files.txt")
file_object = open("files.txt", "r")
text = file_object.read()
file_object.close()
files = text.splitlines()
for file in files:
    if (file[-4:] == ".mp3" or file[-4:] == ".wav" or file[-5:] == ".flac"):
        if (file[-4:] == ".mp3" or file[-4:] == ".wav"):
            ext_len = 3
        elif (file[-5:] == ".flac"):
            ext_len = 4
        bat = open(file[:(ext_len+1)*-1] + ".bat", "w")
        bat.write("ffmpeg -i \"" + file + "\" -acodec libopus -ab 32k \"" + file[:(ext_len+1)*-1] + "\".ogg")
        bat.close()

