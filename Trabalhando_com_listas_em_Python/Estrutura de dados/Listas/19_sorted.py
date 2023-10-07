linguagens = ["python", "js", "c", "java", "csharp"]

print(sorted(linguagens, key=lambda x: len(x)))  
print(sorted(linguagens, key=lambda x: len(x), reverse=True))  