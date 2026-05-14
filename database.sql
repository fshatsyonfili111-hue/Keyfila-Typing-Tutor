-- Keyfila Typing Tutor Database Schema
-- Generated from DatabaseService.cs

CREATE DATABASE IF NOT EXISTS keyfila_db;
USE keyfila_db;

-- 1. Users Table
CREATE TABLE IF NOT EXISTS Users (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(100) UNIQUE NOT NULL,
    Password VARCHAR(255) NOT NULL,
    SecurityQuestion VARCHAR(255),
    SecurityAnswer VARCHAR(255),
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- 2. Lessons Table
CREATE TABLE IF NOT EXISTS Lessons (
    Id INT PRIMARY KEY,
    Title VARCHAR(255) NOT NULL,
    Content TEXT NOT NULL,
    Difficulty INT NOT NULL,
    IsHeader BOOLEAN DEFAULT FALSE,
    ExpectedWPM INT DEFAULT 0
);

-- 3. UserProgress Table
CREATE TABLE IF NOT EXISTS UserProgress (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    UserId INT,
    LessonId INT,
    WPM INT,
    Accuracy DOUBLE,
    Errors INT,
    Stars INT DEFAULT 0,
    CompletedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (LessonId) REFERENCES Lessons(Id),
    FOREIGN KEY (UserId) REFERENCES Users(Id)
);

-- 4. Initial Seed Data (Lessons)
INSERT INTO Lessons (Id, Title, Content, Difficulty, IsHeader, ExpectedWPM) VALUES 
(1, 'J, F, and Space', 'j f j f j f j f jjj fff jjj fff jf fj jf fj jjjj ffff', 0, 0, 15),
(2, 'U, R, and K Keys', 'u r k u r k uu rr kk ur rk uk ku urk kru rku kkk uuu rrr', 0, 0, 15),
(3, 'D, E, and I Keys', 'd e i d e i dd ee ii de ei di id dei ied edi eee ddd iii', 0, 0, 18),
(4, 'C, G, and N Keys', 'c g n c g n cc gg nn cg gn cn nc cgn ngc gcn nnn ggg ccc', 0, 0, 18),
(5, 'Beginner Review 1', 'j f u r k d e i c g n f j r u k i e d n g c jurk deic gn fj', 0, 0, 20),
(6, 'Reaching Out', 'Section 1: Expanding your reach', 0, 1, 0),
(7, 'T, S, and L Keys', 't s l t s l tt ss ll ts sl tl lt tsl lst slt ttt sss lll', 0, 0, 20),
(8, 'O, B, and A Keys', 'o b a o b a oo bb aa ob ba oa ao oba abo bao ooo bbb aaa', 0, 0, 22),
(9, 'V, H, and M Keys', 'v h m v h m vv hh mm vh hv vm mv vhm hmv mhv vvv hhh mmm', 0, 0, 22),
(10, 'Period and Comma', 'a. b, c. d, e. f, g. h, i. j, k. l, m. n, o. p, q. r, s. t.', 0, 0, 25),
(11, 'Beginner Review 2', 't s l o b a v h m . , l s t a b o m h v , . tsolba vhm.,', 0, 0, 25),
(12, 'The Home Stretch', 'Section 2: Completing the keyboard', 0, 1, 0),
(13, 'W, X, and ; Keys', 'w x ; w x ; ww xx ;; wx xw w; ;w wx; ;xw x;w www xxx ;;;', 0, 0, 25),
(14, 'Q, Y, and P Keys', 'q y p q y p qq yy pp qy yq qp pq qyp pyq yqp qqq yyy ppp', 0, 0, 25),
(15, 'Z and Enter Keys', 'z z z z zz zz zzz zzz zzzz zzzz z z z z zz zz zzz zzz', 0, 0, 25),
(16, 'Wrapping Up', 'Section 3: Final Beginner Lessons', 0, 1, 0),
(17, 'Beginner Wrap-up', 'The quick brown fox jumps over the lazy dog. A quick movement.', 0, 0, 30),
(18, 'Beginner Assessment', 'Congratulations on completing the beginner level! Ready for more?', 0, 0, 35),
(20, 'Common English Words', 'the and for are but not you all any can had her was one they with she', 1, 0, 40),
(21, 'Easy Home Row Words', 'as fad dad glad shall flask glass salads falls dallas as fad dad glad shall flask glass', 1, 0, 40),
(22, 'Easy Top Row Words', 'pet wet pot rot toe row tree wire tyre power quite write pet wet pot rot toe', 1, 0, 45),
(23, 'Easy Bottom Row Words', 'man can ban van name came game back bank black neck man can ban van name came', 1, 0, 45),
(24, 'On to Sentences', 'Section 4: Moving to longer text', 1, 1, 0),
(25, 'Shift Key and Capitalization', 'The Quick Brown Fox Jumps Over The Lazy Dog Repeatedly The Quick Brown Fox Jumps Over The', 1, 0, 45),
(26, 'Basic Punctuation', 'comma period question mark semicolon colon slash backslash comma period question mark semicolon colon slash backslash comma', 1, 0, 45),
(27, 'Intermediate Punctuation', 'exclamation mark brackets braces parentheses dash underscore exclamation mark brackets braces parentheses dash underscore exclamation mark brackets', 1, 0, 45),
(28, 'Quick Sentences', 'The sun is shining bright today and we are happy The sun is shining bright today and', 1, 0, 50),
(29, 'Short Paragraphs', 'Typing is a skill that improves with constant practice Typing is a skill that improves with constant', 1, 0, 50),
(30, 'Speed Drills', 'fast quick rapid swift speedy nimble brisk prompt hasty fast quick rapid swift speedy nimble brisk prompt', 1, 0, 55),
(31, 'Wrapping Up', 'Section 5: Final Intermediate Lessons', 1, 1, 0),
(32, 'Intermediate Wrap-up', 'You are doing great keep practicing every single day You are doing great keep practicing every single', 1, 0, 55),
(33, 'Intermediate Assessment', 'This assessment tests your speed and accuracy on words This assessment tests your speed and accuracy on', 1, 0, 60),
(40, 'Skill Builder', 'the quick brown fox jumps over the lazy dog repeatedly and quickly the quick brown fox jumps', 2, 0, 65),
(41, 'Paragraph Practice 1', 'it was a bright and sunny day when the birds were singing in the trees and the', 2, 0, 70),
(42, 'Paragraph Practice 2', 'success is not final failure is not fatal it is the courage to continue that counts in', 2, 0, 75),
(43, 'Advanced Assessment', 'this final assessment will verify your ability to type long paragraphs without any errors at very high', 2, 0, 80)
ON DUPLICATE KEY UPDATE Content=VALUES(Content), Title=VALUES(Title);
