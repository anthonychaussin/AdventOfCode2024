﻿namespace AdventOfCode2024
{
    public class Day2
    {
        private string data =
@"5 6 7 10 13 16 13
19 21 24 27 28 28
16 18 20 21 23 25 29
44 46 48 49 52 55 56 62
51 52 53 50 52
10 11 12 14 11 10
80 83 85 86 88 85 85
89 90 88 90 94
85 86 83 85 92
31 32 32 33 36
17 18 18 19 16
33 34 34 37 39 40 43 43
86 87 89 90 92 92 96
7 9 11 13 16 16 23
59 60 64 67 69
43 45 49 51 48
11 13 14 17 21 22 24 24
74 75 78 82 83 86 88 92
7 8 9 12 16 18 23
35 36 39 45 48 49
10 12 14 15 22 24 21
4 6 11 12 12
84 86 88 93 97
5 7 8 15 16 23
67 66 68 70 71 74 76
17 16 19 20 22 25 22
41 40 42 45 46 47 47
59 56 58 61 63 67
26 25 26 29 31 32 38
81 78 76 79 82 85 86 88
54 52 49 52 54 55 53
24 23 25 23 25 25
29 28 27 30 31 34 38
65 64 66 64 69
88 86 86 87 90 93 96
98 97 97 99 97
68 67 68 71 71 72 72
45 42 45 46 49 49 53
91 89 89 91 92 99
63 62 65 67 68 72 75
79 76 79 80 82 85 89 87
37 35 38 42 42
90 87 88 92 93 97
80 77 80 82 85 89 94
9 6 12 13 15
88 87 89 96 99 97
39 37 39 45 46 49 52 52
6 4 5 6 12 13 16 20
2 1 4 9 12 14 21
80 80 81 84 86
82 82 84 86 85
49 49 51 52 53 54 54
79 79 80 83 85 86 88 92
56 56 59 62 64 65 72
56 56 59 61 63 66 64 67
59 59 58 60 57
66 66 67 68 67 67
25 25 22 25 29
4 4 6 5 12
89 89 89 91 93
6 6 9 11 11 13 16 15
33 33 36 38 39 39 40 40
60 60 63 63 66 67 68 72
62 62 64 67 67 74
30 30 33 37 40 42 44
16 16 20 23 26 27 24
79 79 83 84 85 86 86
28 28 32 34 37 39 43
39 39 40 43 46 50 56
3 3 5 11 14 17 20
54 54 55 56 57 64 62
37 37 42 45 47 47
44 44 50 53 56 59 60 64
32 32 37 40 45
20 24 27 28 30 33 35
15 19 22 25 27 25
84 88 91 92 93 95 97 97
80 84 86 88 89 93
79 83 86 87 88 90 97
39 43 40 43 44 46
70 74 73 76 73
10 14 15 18 16 17 17
44 48 47 49 51 53 57
9 13 14 17 18 20 19 26
60 64 67 70 73 76 76 78
62 66 69 69 70 69
17 21 24 24 27 27
8 12 12 14 17 21
30 34 35 35 38 40 41 48
12 16 20 23 26
67 71 73 75 79 77
37 41 44 48 49 49
24 28 29 32 36 40
63 67 71 74 76 83
58 62 68 70 73 74 75
75 79 81 83 90 89
5 9 14 15 15
10 14 15 21 23 25 27 31
3 7 12 15 20
9 14 17 18 19 21 22 23
1 6 9 12 15 16 15
86 91 92 94 94
64 70 71 74 77 79 83
42 47 49 52 54 61
66 72 74 73 74 75 78 79
41 47 49 48 47
47 53 52 54 54
55 61 62 59 62 63 65 69
60 67 70 67 69 72 77
59 65 67 67 70 73 75
41 48 50 50 51 50
34 41 41 43 44 44
54 60 62 63 64 65 65 69
79 84 87 87 89 92 93 99
11 16 20 21 24
48 53 55 56 60 63 66 64
75 81 83 87 87
24 30 33 37 41
18 23 26 29 33 34 41
10 17 20 22 29 31 33
74 80 83 86 91 89
48 53 59 61 62 62
25 30 32 37 39 42 46
59 66 72 73 78
34 32 29 27 24 22 20 23
99 97 95 92 90 89 86 86
23 22 21 20 17 16 13 9
77 74 73 71 68 65 64 59
31 29 27 24 25 23
91 90 88 85 84 81 84 87
32 31 30 27 25 27 27
52 50 48 46 49 48 47 43
16 15 12 10 8 7 8 1
12 11 8 8 5 2 1
15 13 12 9 9 10
74 71 70 70 67 64 64
68 67 66 65 63 63 61 57
45 42 41 41 34
40 38 34 33 31 28
45 42 38 36 34 37
93 92 90 89 88 84 83 83
31 30 26 23 19
33 32 30 28 26 25 21 14
68 67 60 57 55 54 53 51
32 31 28 25 19 21
83 80 74 72 69 68 68
44 41 38 37 34 29 28 24
59 56 54 47 45 44 37
40 41 38 37 35 33 32
52 53 51 48 47 46 47
32 35 34 32 30 30
58 59 57 54 51 49 46 42
48 51 48 45 44 38
32 35 38 37 34 33
86 89 91 88 85 83 86
61 63 61 60 58 59 57 57
97 98 97 95 92 89 92 88
36 38 41 39 38 33
87 89 89 88 86
92 95 95 92 89 88 91
70 73 71 71 71
69 70 70 68 67 65 61
61 62 62 59 56 54 47
64 66 64 61 57 54
23 24 21 17 15 12 11 14
14 17 16 12 10 8 8
80 81 77 74 72 70 66
30 31 29 27 23 20 17 11
28 31 26 23 21 18
20 21 16 15 12 11 13
41 44 38 36 36
59 60 59 53 49
28 31 30 28 23 22 17
42 42 41 39 37 35 34 31
47 47 44 41 43
89 89 88 85 84 82 80 80
59 59 56 55 52 49 48 44
55 55 54 51 50 43
24 24 21 24 21 19 16 13
92 92 90 89 87 84 85 86
98 98 97 98 97 97
58 58 56 55 58 57 56 52
44 44 43 41 43 41 34
57 57 57 55 54 52 49
87 87 87 86 87
89 89 86 86 85 85
18 18 15 15 14 13 9
34 34 34 31 29 27 26 20
71 71 70 66 65
64 64 62 61 57 56 58
18 18 14 11 9 6 6
83 83 81 78 76 72 68
72 72 68 67 66 65 60
85 85 84 83 77 75 74 71
53 53 51 44 46
8 8 6 1 1
17 17 11 9 5
68 68 67 64 61 55 54 48
20 16 13 12 9 8
99 95 92 89 88 90
33 29 26 23 20 20
70 66 63 60 56
37 33 31 29 28 23
27 23 21 22 19
81 77 76 73 71 69 70 72
30 26 29 28 27 24 23 23
21 17 19 18 15 13 9
91 87 85 82 80 82 80 73
83 79 79 77 75 74
86 82 81 81 78 79
85 81 78 76 76 76
77 73 73 71 69 66 62
68 64 62 62 55
26 22 19 15 13
10 6 2 1 4
56 52 51 48 45 41 38 38
21 17 14 11 7 3
61 57 53 52 50 43
23 19 17 10 8 6
81 77 76 74 68 66 68
87 83 78 75 75
42 38 37 35 29 26 25 21
62 58 55 54 47 40
70 65 63 62 61 58 56 53
88 82 81 78 76 75 74 76
29 24 23 21 20 19 18 18
26 20 18 16 14 11 10 6
68 61 59 58 57 55 52 46
25 19 16 19 18 15
51 45 43 46 47
24 18 21 20 19 18 18
30 23 21 24 20
72 65 63 65 64 58
81 74 71 68 68 66 63
46 41 40 40 37 34 33 36
51 45 45 42 40 39 39
47 41 39 39 35
32 25 24 24 19
89 82 80 78 74 71
70 64 61 59 58 54 55
66 61 59 55 55
60 54 53 49 46 43 39
70 63 61 59 55 52 45
37 30 23 22 20 19 16 13
70 64 57 55 56
72 67 64 61 59 57 52 52
67 62 57 54 53 50 46
40 34 31 28 21 20 17 11
52 55 57 60 63 66 63
10 11 12 13 14 16 16
84 87 88 90 91 95
12 14 17 19 20 21 26
46 49 48 51 54
16 18 21 20 19
66 68 71 69 71 72 72
9 12 14 11 14 18
79 80 82 80 83 90
13 14 17 17 20
4 5 6 6 7 10 9
76 77 79 79 79
70 73 73 75 76 78 79 83
29 31 34 34 37 38 45
69 71 74 78 80 81
7 8 11 15 17 14
43 44 48 49 50 50
1 3 7 8 12
40 42 46 47 52
65 66 67 73 74
11 14 16 17 23 22
4 6 7 9 15 16 16
68 69 70 73 75 81 85
46 48 55 56 58 64
34 33 34 35 38 41 42 45
76 75 78 79 81 84 83
78 76 78 80 82 85 88 88
9 6 7 10 14
4 1 2 3 4 5 8 13
22 20 23 25 23 25 27 29
51 50 53 50 52 54 57 55
79 77 76 77 77
30 28 31 33 36 35 39
76 75 76 79 81 80 81 88
6 3 4 6 9 9 12 14
31 30 32 32 33 30
91 89 92 92 94 94
79 78 81 84 86 86 90
4 2 5 5 7 9 11 17
15 13 15 17 21 22
33 30 31 34 38 35
49 46 50 51 54 55 55
65 63 67 70 72 76
11 9 10 11 15 18 21 28
6 4 6 8 15 18
74 71 73 78 81 83 84 82
62 60 67 68 69 69
71 70 73 75 76 79 85 89
11 9 12 14 19 22 24 29
31 31 33 36 38 40 42 45
8 8 9 12 14 16 17 15
57 57 59 61 62 64 64
29 29 32 35 37 39 42 46
56 56 57 60 61 62 69
66 66 67 66 69
31 31 28 30 28
20 20 19 20 22 25 25
2 2 3 5 8 7 11
5 5 6 9 12 11 14 21
15 15 16 18 20 22 22 23
90 90 90 92 95 97 96
54 54 56 56 59 59
67 67 68 69 69 70 74
44 44 44 46 51
7 7 9 12 16 19
46 46 47 51 52 51
22 22 26 27 29 30 30
76 76 78 79 82 84 88 92
16 16 17 19 23 25 30
28 28 31 36 39 42
13 13 14 20 18
41 41 46 47 50 50
79 79 84 87 91
79 79 80 87 89 90 93 99
6 10 11 13 16
80 84 86 89 91 93 91
24 28 30 31 34 37 37
49 53 55 57 61
44 48 51 53 59
17 21 24 25 26 25 28
73 77 79 77 79 77
76 80 79 80 82 84 84
75 79 80 81 83 82 86
26 30 33 36 37 35 41
52 56 59 59 61 62 65 67
9 13 16 18 18 21 19
78 82 82 85 87 87
22 26 28 31 31 35
48 52 52 55 60
43 47 48 52 54 56
24 28 30 32 36 39 38
46 50 54 56 57 58 61 61
13 17 20 24 28
8 12 14 17 19 23 30
7 11 12 14 21 24 26 28
25 29 35 37 38 41 39
34 38 44 46 48 48
40 44 45 52 53 57
74 78 79 80 86 93
72 77 79 80 81 83
77 83 86 88 90 92 91
65 70 73 76 79 82 83 83
31 36 39 42 43 47
41 47 48 49 50 51 52 59
35 40 37 38 41
73 80 79 80 81 80
77 83 84 87 86 89 92 92
29 34 36 39 40 39 43
2 7 9 10 9 14
81 87 89 89 90 93
68 75 77 80 80 83 84 83
76 83 86 86 87 89 89
56 61 64 67 67 69 71 75
54 60 61 64 64 71
50 55 59 62 65
43 48 51 55 57 56
51 56 57 60 63 67 69 69
54 60 63 64 68 71 75
52 59 63 64 69
67 72 75 81 84
6 12 17 20 23 24 25 22
6 13 14 16 17 24 24
40 46 49 50 57 60 61 65
6 11 18 21 23 28
16 13 12 9 8 11
68 67 66 65 62 62
46 45 44 42 40 36
49 48 47 46 43 42 41 34
93 92 91 88 90 88
87 86 87 84 83 85
35 34 31 28 31 31
15 13 15 13 9
63 61 58 56 57 54 49
21 20 20 19 16 14 13
54 53 52 52 49 51
17 15 14 11 11 11
89 86 83 83 82 81 77
99 98 97 94 94 88
38 37 34 30 28
19 17 16 14 10 13
46 43 39 37 34 33 30 30
17 14 13 9 6 5 1
20 18 14 11 5
91 90 89 88 87 80 79 78
62 60 57 56 54 48 47 49
94 92 90 85 85
50 49 44 42 38
49 46 39 37 36 34 32 26
63 66 63 60 57 55
58 60 58 56 57
49 51 50 49 47 47
50 52 51 50 48 47 43
9 11 10 8 1
48 49 52 49 46 44
46 47 46 43 40 43 40 42
87 90 89 92 90 90
98 99 97 96 95 97 96 92
76 77 79 77 71
28 29 29 27 25 23 22
95 98 98 95 92 90 87 89
64 67 64 62 59 58 58 58
92 95 92 90 87 87 83
51 53 52 50 50 44
81 82 78 77 75 72 69 68
53 56 55 51 49 51
26 29 25 24 21 21
40 41 39 35 32 29 26 22
22 25 21 19 17 11
65 68 62 60 57
75 77 76 70 68 66 64 65
50 52 46 43 43
53 55 53 46 43 40 36
63 64 63 57 56 53 48
42 42 41 39 36 35 34 31
70 70 69 66 65 68
82 82 79 78 78
47 47 46 44 40
55 55 53 50 44
62 62 59 58 61 59 58
88 88 87 85 87 88
68 68 66 68 68
32 32 29 28 29 27 25 21
24 24 26 24 18
95 95 93 92 92 89
72 72 69 69 68 67 64 67
27 27 24 22 19 19 19
26 26 23 20 20 19 17 13
9 9 8 8 6 1
58 58 57 54 53 51 47 45
95 95 91 90 92
13 13 10 6 6
87 87 85 84 80 76
81 81 77 74 73 71 66
94 94 92 91 85 83 82
33 33 32 30 29 23 20 22
92 92 91 84 83 83
16 16 10 8 7 5 1
60 60 58 55 50 48 43
43 39 37 36 34 33 32 29
88 84 81 80 78 75 74 76
37 33 30 29 26 25 23 23
76 72 69 68 67 63
95 91 90 87 82
85 81 78 81 80 77
35 31 28 26 27 29
80 76 78 77 75 75
35 31 29 31 29 25
96 92 89 91 90 87 81
51 47 45 44 44 41
91 87 86 83 80 79 79 82
50 46 46 45 44 42 42
60 56 54 54 50
86 82 79 79 78 77 70
63 59 55 54 51
39 35 33 30 29 25 23 26
90 86 83 79 77 75 74 74
70 66 63 62 61 57 53
63 59 56 52 51 48 45 38
77 73 67 66 64 62 61
22 18 15 14 8 5 8
82 78 76 75 68 66 66
31 27 22 21 17
70 66 61 58 57 51
61 54 52 49 46 45 43
81 75 72 69 66 65 66
37 30 29 28 25 24 24
75 70 67 65 64 60
59 53 50 47 44 41 40 34
48 43 45 43 42
41 34 37 35 38
52 46 43 41 40 37 39 39
38 32 35 32 29 27 23
76 70 73 71 69 66 60
16 11 9 9 6 5
20 13 13 10 8 10
71 66 64 63 61 61 61
60 55 53 51 51 47
27 20 20 18 17 10
83 77 75 73 71 67 65 62
87 81 79 75 78
81 75 71 69 66 66
76 71 70 67 65 61 57
72 67 64 62 59 56 52 45
39 32 30 24 23 20 17 15
94 88 86 80 79 82
27 20 19 13 10 10
96 89 82 80 77 73
34 27 25 20 18 16 11
46 47 49 50 54 56 59 63
87 87 90 91 92 91 92 92
80 81 80 78 75 68 67 67
29 28 25 23 18 15 13
29 29 27 24 21 17
62 64 65 64 66 69 72 72
18 18 21 24 21 28
55 57 52 49 45
76 78 76 73 69 66 66
77 76 73 70 66 60
73 77 81 84 86
64 70 72 75 78 81 81 81
79 80 87 89 90 91 96
22 26 29 28 30 36
76 73 72 70 70 68 66 63
44 41 42 44 46 52
47 47 45 44 41 39 38 37
52 50 48 48 47 47
33 37 41 42 43 45 45
31 37 37 39 42 45 46
36 38 40 43 46 51
69 62 61 59 58 55 55
64 66 67 67 69 71 69
58 58 60 60 63
50 53 51 52 50 47 43
76 72 70 69 67 69
38 33 32 34 33
20 20 17 17 16 13 7
49 50 52 53 57 58
67 66 67 70 72 74 77 80
54 50 45 43 41 38 35 35
13 12 13 14 18
90 86 82 81 79 72
97 90 89 85 82 82
70 77 79 81 88 90 92 96
89 85 82 82 83
41 41 40 39 39 37 34
43 41 44 47 46 49
38 42 47 48 49
89 90 97 99 98
20 27 31 32 35 38 38
41 41 38 37 34 32 32
23 19 17 16 15 16 16
93 93 92 91 90 92
79 75 74 73 69 66 65 61
67 70 71 72 73 75 78 78
35 40 41 42 39 38
87 84 83 81 78 77 76 76
62 56 55 58 54
55 53 57 60 63 64
20 22 19 20 19 19
14 14 11 14 16
27 26 27 28 31 30 31 37
15 9 8 7 6 6 2
41 38 37 30 29 27 21
70 75 76 77 80 83 86 86
20 18 14 13 10 7 3
47 44 40 38 36
10 14 15 18 19 20 22 27
60 60 62 64 66 69 74 76
13 17 15 17 18 19 20 17
12 11 13 15 15 16
97 97 94 91 91 94
30 32 33 33 36 39 41 45
46 40 39 36 39
33 39 41 44 48 50 49
31 31 29 27 25 18 16 18
12 12 15 17 19 23 21
43 42 45 45 46 49 46
47 49 50 52 53 56 59 63
59 60 58 58 56 54 53
15 20 22 25 27 28 34 37
54 57 58 59 62 68 69
43 47 49 50 48
63 67 68 69 71 74 78
82 85 84 80 77 74 71 67
85 90 91 94 95 98 97
85 81 79 80 77 76
26 20 16 14 13 11 5
57 59 60 63 62 65 68 72
21 21 18 12 7
62 59 57 55 54 51 50 44
64 66 65 65 60
12 16 15 17 19
12 14 14 13 11 8 8
92 90 89 91 93 95 97 95
90 88 91 93 95 92
79 84 87 94 95 96 99 96
20 23 24 26 29 33 34 41
48 43 42 41 40 37
37 37 40 39 36 36
56 56 57 58 61 60
68 66 66 65 63 61 58 53
59 61 60 57 57
56 49 47 49 47 46 43 36
21 19 17 16 10 9 7 7
28 35 38 42 43 50
83 83 80 77 76 72 69 69
33 32 36 38 39 40 44
67 71 72 73 72 74 77 81
31 36 39 39 41 45
61 64 68 71 73 70
64 64 64 67 70 73 76 82
47 40 39 36 33 31 28 22
48 51 49 44 42 41
48 47 48 50 51 51 51
69 69 73 74 77 79 81 85
5 9 10 13 15 15 17 21
71 75 78 82 87
46 42 39 38 35 36 35 38
10 12 14 17 18 22 23 23
75 76 76 78 81 83 85 85
11 15 16 18 19 23 27
64 68 75 76 79 82 87
81 79 76 73 75 75
21 17 15 10 9 6 4 3
67 74 76 77 82
22 26 30 32 35 32
23 20 17 15 13 11 10 6
64 63 62 60 55 53 56
34 34 36 40 42 44
43 43 42 42 38
31 28 32 33 36 39 36
74 71 75 77 79 81 88
97 90 88 86 79 73
60 60 61 63 64 68
46 44 41 44 48
17 13 14 13 12 9 8 4
75 69 67 64 59 57 58
27 21 21 19 16 14 9
29 29 26 23 21 20 18 11
57 60 63 66 67 69 71 68
75 78 75 73 74 71 73
46 40 33 30 27 24 22 22
71 73 69 66 63 65
79 81 80 82 84 81
79 83 84 85 86 88 89 89
8 12 17 20 23 27
78 83 86 89 91 95 99
39 40 38 35 28 25 24 25
50 47 50 51 53 59 56
75 75 74 70 69 67 70
81 74 73 71 70 66 62
34 30 27 23 20 17 15 15
49 52 49 46 43 41
50 55 56 53 57
57 57 57 59 60 64
87 81 80 77 80 78 78
69 68 71 72 73 74 78 78
46 40 38 31 29 27 25
24 23 22 22 19 16 14 16
22 27 28 31 32 33
90 90 84 81 80 76
51 55 58 59 60 63 66
9 7 14 16 20
47 51 53 53 55 57 58
63 59 56 53 50 47 40
52 45 42 38 35 34 33
27 24 24 26 32
13 18 21 22 19 20 23
21 20 23 25 32 33 35 35
80 81 82 85 86 86 92
49 49 51 50 48 46 43 41
69 63 62 61 57 56 55 57
8 8 9 11 8 12
90 86 83 81 84 78
94 94 91 88 85 81 79 73
14 17 16 15 12 10 7 3
70 65 63 63 60 60
72 72 70 66 63 61 58 54
72 68 66 63 56 54 50
56 55 52 51 50 48 44 45
95 88 88 87 86 83 85
41 45 47 50 55 58 58
71 74 77 74 73 70 67 60
74 74 81 83 85 86 87 91
22 26 27 25 25
89 88 85 84 87 89
86 84 81 82 81 74
49 42 37 34 30
83 81 86 89 96
82 77 79 77 80
24 29 30 33 36 40 41
62 69 72 75 77 81
27 23 20 18 17 14 14
25 26 21 20 19 12
18 18 16 15 16 13 12 6
65 65 62 61 58 52 51 51
53 53 55 56 59 66 73
52 55 56 54 56 59
87 90 88 87 89
68 64 61 58 55 52 50
76 77 75 78 77 74
53 49 47 44 40
66 62 60 59 55 53 55
73 69 65 63 60 58 55 52
10 17 19 26 28 34
36 36 38 40 42 46 47 47
29 33 36 36 37 39 36
6 9 16 19 22 26
46 40 40 38 36 34 33
70 70 71 72 73 80 83 83
66 64 61 60 60 57 53
38 34 27 26 24 23 25
70 67 66 69 70 73 73
15 12 10 7 5
61 62 65 66 69 71 73 76
75 76 77 80 82 85 87 90
83 82 81 78 76
52 50 48 46 43 42
34 32 31 30 29 27
53 55 57 58 61 64 65 68
23 22 19 18 16 15
36 35 33 30 29 26 23 21
43 41 38 35 32 31 28
96 94 91 89 88 86 84 83
94 93 92 90 87 85 84 81
83 86 89 90 93
42 45 48 51 52 53
3 4 6 7 10
83 81 80 78 77 74 71 69
69 66 63 61 58
17 16 14 12 9
74 73 70 68 65 63
41 44 46 47 48 51
81 79 78 77 74
11 14 16 17 18 21 23
79 82 83 85 86 89 92 95
88 87 86 83 82 79 76
28 31 33 36 37 38 40
55 56 59 60 61 63 65
57 60 62 64 67 70 73
58 60 63 66 69 70 73 74
24 22 21 20 18
76 79 82 85 87 90 93
29 27 25 23 22
31 32 33 35 37 39 40
14 12 11 8 7 5 4
80 77 74 71 68 67 66 63
57 59 60 63 65 66 69
96 93 92 90 87 85
76 77 80 82 83 86
20 23 25 27 30 32
26 29 32 34 37 38 41
31 30 29 27 24
31 34 35 36 37 38 41
78 77 75 72 71 69 66
49 47 45 42 40 37 34
94 93 92 91 88
81 78 76 75 74 72 71
7 10 13 16 17 20 23
63 64 66 67 68
9 7 5 4 3
75 73 71 68 66 64 61
64 67 68 69 71 74
60 62 64 67 70 71 73
63 64 67 70 73 75
95 93 92 89 88
40 39 38 36 35
30 28 26 24 23
26 24 21 20 18 17 15
90 91 92 93 96 97
4 5 6 8 10 12 14
36 33 32 30 28
67 66 64 62 60 58 56
52 51 49 48 46 45
16 17 18 21 23 24 27 28
26 28 31 33 35 37 39 40
79 81 82 85 88
36 39 41 44 46
43 45 46 48 51 52 53
49 46 45 43 41 39
24 27 29 32 34 36
55 54 52 49 48
69 72 75 77 80 81 82
13 12 10 7 6
9 10 12 15 16 18 20
76 77 78 80 81 82 84
68 71 72 73 74
26 24 23 22 20 18
38 37 34 33 30 29
53 52 49 48 47 45 42
32 30 27 24 22 20 18
34 35 37 38 41 44 46
5 6 8 10 13 16 17 19
40 38 37 34 31 28 25 23
4 6 7 9 12 15 18
9 11 13 14 16 19 22 23
69 67 66 65 63 62 59 57
81 84 85 87 90 91 94 97
54 56 59 62 65 67 68 70
53 55 58 61 64
65 66 69 71 74 76 77
93 92 90 88 87 85 83 81
83 80 77 75 74
77 76 75 74 73
90 88 85 84 82 80 77 74
58 60 61 62 65
2 5 7 8 9 10 12
46 45 44 41 40
85 83 82 80 79 77 75 72
99 97 95 93 92 89
67 69 72 75 78
79 77 76 74 72
43 45 48 51 54 57 60
98 95 92 91 90 88
41 44 47 49 52 55 56 57
68 66 64 62 61 59 56 55
66 69 72 74 76 78 80 81
72 75 76 79 81 84 86
99 97 94 91 89
52 55 58 59 61 63
80 81 84 86 88 91 93
8 9 10 12 15 17 18
90 91 93 96 99
30 31 34 36 38
90 88 85 82 79 76 74 72
82 84 87 88 89 92
12 9 7 6 3
83 84 87 89 91 94 97
33 36 39 41 42 45 48
7 8 11 13 14 15
48 49 50 51 54 56
92 89 86 83 80 78
60 62 63 66 67 70 71
25 24 21 19 16 13
29 26 25 23 21
71 68 67 64 63
83 85 88 89 90 91 93 95
2 4 7 10 12 13
54 53 50 47 45
8 10 12 13 15 18 19 20
83 82 81 80 77 76 74 71
93 90 88 87 85 84 81 79
76 77 80 81 82 85 86
42 39 37 36 34 32 29 26
48 47 46 44 41 39 36
39 38 37 36 33 32 30
12 15 17 19 20 21 22
30 29 28 27 24 22
37 40 42 43 46 48 50
35 38 39 42 45 48 50
55 58 59 60 62
7 8 11 13 15 16 18
68 67 66 64 61 60
77 79 81 83 84 87 88
60 59 56 54 52 51 50 49
14 16 17 20 22 25 28 30
60 63 66 68 69 70 72
19 16 14 11 9 6 5 3
57 58 61 64 65 66 68
44 42 41 38 37
72 74 75 78 79 82 84
51 54 56 59 60
69 67 66 64 62
33 30 27 25 24
56 54 53 52 50 48
76 78 81 84 86 89 90 93
77 74 71 68 66 64 61 59
41 39 36 35 32 31
75 73 71 69 68 67 64
75 76 78 81 82 83
78 81 83 86 87 88 91 94
33 30 27 25 24 21 19 16
46 47 48 50 51 54 56 59
76 78 79 82 84 87
71 73 75 77 78 79 80
52 54 56 59 61 63 65
7 10 12 13 15 18
3 6 8 10 12 13
78 80 82 84 86
58 55 53 50 47 45
88 85 82 79 78 77 74
8 7 6 5 3 2
38 36 33 30 29 28
59 62 63 66 68 70
83 86 88 89 91 93 96 99
19 21 23 26 28 31
14 16 19 22 25 27
91 90 88 87 86 85 84 83
5 8 11 14 17 18 20
87 88 91 92 94 96 97
4 5 6 8 9
32 30 27 24 23 20
56 55 54 52 49 48
31 30 28 27 24 22 19
79 82 85 86 88 89 90 91
92 89 87 84 83 80
75 72 71 69 67
54 51 49 46 45 44 41 38
38 36 35 34 31
68 66 63 62 59 58
90 89 87 86 84 81 78
51 52 54 57 59 60 61 62
18 19 20 21 23 25
52 50 47 45 44
71 73 74 76 79 82 85
19 21 23 25 26
47 46 43 41 40 38 36 33
32 35 37 40 42 43 45
57 54 52 50 47 46 44 42
33 35 37 40 43 44
38 35 33 32 29 26 24 23
63 61 60 57 56
90 87 84 83 81 80 79 76
11 13 14 15 18 19 21
59 56 53 51 48 47 44
54 56 57 60 61 63
26 27 29 31 34 35 38
64 63 61 59 58 55 54
17 15 14 12 10 7
85 86 88 91 94
23 26 29 30 32 33 36 37
31 32 33 34 36 38 39
88 89 92 94 97
74 72 70 67 64 61
18 17 14 11 10 8 5 2
66 63 60 57 54 51 48
49 52 55 56 58 59 62
55 52 49 48 47 46 45
59 57 56 55 54 53 50
25 26 28 29 31 32 33
52 50 48 47 46 45 44 41
48 47 46 44 41
16 14 13 12 9
18 19 20 21 24
34 37 40 43 44
46 49 51 54 56
81 79 78 77 75 72 69 68
26 24 22 19 17 16 13
19 21 24 26 27 30
13 14 16 18 19 22 24 26
41 43 45 46 47 48
92 89 87 85 84
34 35 38 39 40 41 44
96 95 93 90 89
66 68 69 70 71 72
82 79 78 77 74
40 38 37 34 33 31 28
71 72 74 76 78 80 81 83
37 36 34 32 31 28 27 25
40 42 44 47 49 51 52
84 81 78 77 76 75
22 23 25 26 29 31 32 35
35 34 33 31 29 28 25
34 36 38 41 44 46 47 49
51 48 46 43 42 41 38 36
1 2 4 5 7
70 68 65 64 62
34 31 30 29 27 26
35 34 31 29 26
33 35 38 39 42 45
65 64 61 59 56 53
65 63 60 57 55
38 36 33 32 29
59 61 64 65 66
93 92 89 86 84 83 82
14 13 12 9 7
63 66 69 70 72 75 76 79
31 32 33 36 37 39
37 39 40 42 45 47
20 22 23 25 26
55 52 49 46 45 42
19 21 23 24 27 30 33
2 4 6 7 9 12 15 16
76 79 80 82 83 84 87
49 51 52 53 55 57
54 55 57 59 61
3 5 6 9 12 14 15
95 92 91 88 87 84 83 80
54 56 57 58 61 62 63
1 3 5 6 8 10
76 79 80 82 85
21 23 24 27 28 31 33
52 49 46 43 41 40 38
69 71 74 76 77
57 55 52 49 48
22 19 16 14 11
67 68 70 72 73 74 75 76
17 14 13 10 7 6 3 2
76 73 72 71 69 67 66
70 72 73 75 78 79
56 53 50 47 44 43 42 39
72 70 68 66 64 61
80 81 84 86 87 90
35 32 29 28 26 25
30 33 35 36 39 40 41 43
62 59 57 56 53
51 48 46 44 43
32 31 29 28 25 23 21 19
90 89 87 85 84 81 80 79
66 64 62 59 56 55 54 53
70 71 72 73 74 76 79 81
84 86 88 89 92 94 95 98
61 60 58 56 54
79 81 83 86 87 89 92
23 20 17 16 15 14 11 8
39 38 37 34 33 32
14 13 10 8 7 6
29 31 34 37 38 41 43
22 24 26 28 29 30
31 28 27 25 24
51 50 49 48 46 44 43
69 70 71 74 75 77";

        public List<List<int>> Data
        {
            get
            {
                return data
                    .Split("\r\n")
                    .ToList()
                    .ConvertAll(d => d.Split(" ")
                    .ToList()
                    .ConvertAll(int.Parse));
            }
        }

        public static bool IsSafe(List<int> ints, bool isFirstTry = true)
        {
            var orderDescanding = ints.First() > ints.Last();
            var result = new Dictionary<int, bool>();

            for (int i = 1; i < ints.Count; i++)
            {
                result.Add(i, Day2Compare(ints[i - 1], ints[i], orderDescanding));
            }

            if (!result.Any(e => !e.Value))
            {
                return true;
            }

            if (!isFirstTry)
            {
                return false;
            }

            var badIndex = result.First(e => !e.Value).Key;
            var previous = new List<int>(ints);
            var current = new List<int>(ints);

            previous.RemoveAt(badIndex - 1);
            current.RemoveAt(Math.Min(ints.Count, badIndex));

            return IsSafe(previous, false) || IsSafe(current, false);
        }

        private static bool Day2Compare(int one, int two, bool byDescanding)
        {
            if (one == two || Math.Abs(one - two) > 3)
            {
                return false;
            }
            else
            {
                return byDescanding ? one - two > 0 : two - one > 0;
            }
        }
    }
}