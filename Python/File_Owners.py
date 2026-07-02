class FileOwners:

    @staticmethod
    def group_by_owners(files):
        sorted_files = {}
        for item in files:
            if not files[item] in sorted_files:
                sorted_files[files[item]] = []
            sorted_files[files[item]].append(item)
        return sorted_files

files = {
    'Input.txt': 'Randy',
    'Code.py': 'Stan',
    'Output.txt': 'Randy'
}
print(FileOwners.group_by_owners(files))
