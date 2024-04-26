def destroy_lasers(lasers):
    # 발사기를 좌표 값이 작은 순서대로 정렬
    lasers.sort()

    # 발사기 수를 세는 변수
    count = 0

    # 발사기가 모두 파괴될 때까지 반복
    while lasers:
        # 가장 왼쪽에 있는 발사기 선택
        x, f = lasers[0]

        # 선택한 발사기의 범위에 해당하는 발사기들을 제거
        lasers = [laser for laser in lasers if laser[0] > x+f or laser[0]+laser[1] < x]

        # 선택한 발사기를 동작시킴
        count += 1

    return count

# 테스트 케이스 수 입력
test_cases = int(input())

# 각 테스트 케이스에 대해 처리
for case in range(1, test_cases + 1):
    # 발사기 수 입력
    n = int(input())

    # 발사기 좌표와 강도 입력
    lasers = []
    for _ in range(n):
        x, f = map(int, input().split())
        lasers.append((x, f))

    # 최소 발사기 수 계산
    result = destroy_lasers(lasers)

    # 결과 출력
    print(f"#{case} {result}")