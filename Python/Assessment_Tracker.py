# Assessment_Tracker.py
# Stefan Grace
# Created: 2018-09-10


class Assessment:
    def __init__(self, paper_name, asessment_name, mark):
        self.paper_name = paper_name
        if len(assessment_name) > 0:
            self.assessment_name = assessment_name
        else:
            slef.assessment_name = "Assessment"
        if mark >= 0 and mark <= 100:
            self.mark = mark
        else:
            self.mark = 0
    def get_paper_name():
        return paper_name
    def get_assessment_name():
        return assessment_name
    def get_mark():
        return mark

class Tracker:
    def __init__(self, size):
        bookmark = 0
        if size > 0:
            assessments = range(size)
        else:
            assessments = range(12)
    def add(self, an_assessment):
        if bookmark < len(assessments):
            assessments[bookmark] = an_assessment
            bookmark += 1
            return "Assessment has been added"
        else:
            return "Tracker is full. Assessment connot be added"
    def average(self):
        total = 0
        for i in range(bookmark):
            total += assessments[i].get_mark()
        return total / bookmark
    def lst(self, paper_name):
        output = ""
        for i in range(bookmark):
            if assessments[i].get_paper_name() == paper_name:
                output += assessments[i].get_assessment_name() + ": " + assessments[i].get_mark + "\n"
            if len(output) > 0:
                return output
            else:
                return "Paper not found"


tracker = Tracker(9)
user_input = ""
while user_input != "exit":
    user_input = input("Tracker: ").lower()
    if user_input == "add":
        paper_name = input("Paper Title: ")
        assessment_name = input("Assessment Name: ")
        try:
            mark = int(input("Mark: "))
        except:
            mark = 0
        new_assessment = Assessment(paper_name, assessment_name, mark)
        print(tracker.add(new_assessment))
    elif user_input == "average":
        print("Average Mark: " + tracker.average())
    elif user_input == "list":
        print(tracker.lst(input("Paper Title: ")))
    elif user_input != "exit":
        print("Command not recognised")
print("Tracker is closed")
        
