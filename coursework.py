import random

elements = []
containers = [0]

for value in range(0, 10000):
    elements.append(random.random())
elements.sort(reverse=True)

for value in elements:
    if containers[-1] + value <= 1:
        containers[-1] += value
    else:
        containers.append(value)

print(str(len(containers)) + " containers need")
