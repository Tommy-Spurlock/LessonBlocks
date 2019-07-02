using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DanceBlocks.Data.Migrations
{
    public partial class Addedseeddatafordbfirstrun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "00000000-ffff-ffff-ffff-ffffffffffff", 0, "4a00975b-f609-4a86-8fa6-e956daaaaf2e", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEHU+Ogj+xILZCFt4I8gQN9/iGNG+UoaUPEFH7jXd+OmdZQX5LuK+wsTBjMOSG0GiDQ==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com", "Admina", "Straytor" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Rhythm" },
                    { 2, "Smooth" }
                });

            migrationBuilder.InsertData(
                table: "DanceTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Rumba" },
                    { 2, "Cha Cha" },
                    { 3, "East Coast Swing" },
                    { 4, "Waltz" },
                    { 5, "Tango" },
                    { 6, "Foxtrot" }
                });

            migrationBuilder.InsertData(
                table: "SkillLevels",
                columns: new[] { "Id", "Level" },
                values: new object[,]
                {
                    { 1, "Beginner" },
                    { 2, "Intermediate" },
                    { 3, "Advanced" }
                });

            migrationBuilder.InsertData(
                table: "DanceCategories",
                columns: new[] { "Id", "CategoryId", "DanceTypeId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 2, 4 },
                    { 5, 2, 5 },
                    { 6, 2, 6 }
                });

            migrationBuilder.InsertData(
                table: "Steps",
                columns: new[] { "Id", "DanceTypeId", "Description", "Name", "SkillLevelId" },
                values: new object[,]
                {
                    { 15, 2, "Penatibus et magnis dis parturient montes nascetur ridiculus mus mauris. Leo integer malesuada nunc vel risus commodo viverra maecenas accumsan. Accumsan sit amet nulla facilisi morbi tempus iaculis urna. Vitae justo eget magna fermentum iaculis eu non. Ultrices gravida dictum fusce ut placerat orci. Consectetur lorem donec massa sapien faucibus et molestie. Curabitur gravida arcu ac tortor dignissim convallis aenean et. Et molestie ac feugiat sed lectus vestibulum mattis ullamcorper velit. Potenti nullam ac tortor vitae purus faucibus ornare suspendisse. Sed arcu non odio euismod lacinia. Metus aliquam eleifend mi in nulla posuere sollicitudin aliquam. Nunc sed blandit libero volutpat sed cras ornare arcu dui. At consectetur lorem donec massa sapien faucibus. Tortor pretium viverra suspendisse potenti nullam ac tortor. Blandit volutpat maecenas volutpat blandit aliquam etiam erat.", "Backspot Turn", 3 },
                    { 12, 3, "Eu volutpat odio facilisis mauris sit amet massa vitae tortor. Odio ut enim blandit volutpat maecenas volutpat blandit. Et malesuada fames ac turpis egestas sed tempus urna et. Molestie ac feugiat sed lectus. Eget mauris pharetra et ultrices. Justo laoreet sit amet cursus sit. Interdum consectetur libero id faucibus nisl tincidunt eget nullam. Venenatis tellus in metus vulputate eu scelerisque. Lacus suspendisse faucibus interdum posuere lorem ipsum dolor sit. Elit scelerisque mauris pellentesque pulvinar pellentesque. Morbi tincidunt augue interdum velit euismod in pellentesque. Sit amet commodo nulla facilisi nullam vehicula ipsum a arcu. Potenti nullam ac tortor vitae purus faucibus ornare suspendisse sed.", "Walks and Kicks", 3 },
                    { 9, 4, "Lead: Starting with left foot, take 1 steps forward. Side step to right and close left foot. Starting with right foot; side step, open break with left foot and return weight to right foot. Side step to left foot and lift left arm. Open break to right foot as partner passes under left arm into turn. Return weight to left foot, lower left arm and side step to right. Hold for 2 counts while reconnecting with partner. Follow: Starting with right foot, take 1 steps backwards. Side step to left and close right foot. Starting with Left Foot; side step, open break with right foot and return weight to left foot. Side step to right foot and connect right hand into partners left hand. With left foot, step outside partner and on right foot spin back closed to partner.  Side step to left.", "Open Break Underarm Turn", 3 },
                    { 6, 5, "Lead: Starting with left foot, take 2 steps forward. Beginning on 3rd step while rotating right take four quick rock steps. Finish with Tango Basic. Follow: Starting with the right foot, take 2 steps backwards. Beginning on 3rd step while rotating right take four quick rock steps. Finish with Tango Basic.", "Tango Double Spin Turn", 3 },
                    { 3, 6, "*Box Timing* Lead: Starting with left foot, take 1 step forward, a half diagnal step w/right foot into a promenade left step. Finish with brushing right step and close box step.  Follow: Starting with the right foot, take 1 step backward, a half diagnal step w/ left foot into a promenade right step. Finish with brusing left step and close box step.", "Basic Twinkle ", 3 },
                    { 17, 1, "Penatibus et magnis dis parturient montes nascetur ridiculus mus mauris. Leo integer malesuada nunc vel risus commodo viverra maecenas accumsan. Accumsan sit amet nulla facilisi morbi tempus iaculis urna. Vitae justo eget magna fermentum iaculis eu non. Ultrices gravida dictum fusce ut placerat orci. Consectetur lorem donec massa sapien faucibus et molestie. Curabitur gravida arcu ac tortor dignissim convallis aenean et. Et molestie ac feugiat sed lectus vestibulum mattis ullamcorper velit. Potenti nullam ac tortor vitae purus faucibus ornare suspendisse. Sed arcu non odio euismod lacinia. Metus aliquam eleifend mi in nulla posuere sollicitudin aliquam. Nunc sed blandit libero volutpat sed cras ornare arcu dui. At consectetur lorem donec massa sapien faucibus. Tortor pretium viverra suspendisse potenti nullam ac tortor. Blandit volutpat maecenas volutpat blandit aliquam etiam erat.", "UnderArm Turn", 2 },
                    { 14, 2, "Posuere urna nec tincidunt praesent semper feugiat nibh sed pulvinar. Sem fringilla ut morbi tincidunt augue interdum velit euismod. Congue mauris rhoncus aenean vel. Eget duis at tellus at urna condimentum. In hac habitasse platea dictumst vestibulum. Quis hendrerit dolor magna eget est. At ultrices mi tempus imperdiet nulla malesuada pellentesque. Hac habitasse platea dictumst vestibulum rhoncus est pellentesque. Tempus imperdiet nulla malesuada pellentesque. Faucibus scelerisque eleifend donec pretium vulputate sapien.", "Crossover Breaks", 2 },
                    { 11, 3, "Eros in cursus turpis massa tincidunt dui ut ornare lectus. Netus et malesuada fames ac turpis. Magna fermentum iaculis eu non diam phasellus. Cras tincidunt lobortis feugiat vivamus at augue. Arcu ac tortor dignissim convallis aenean et. Ipsum dolor sit amet consectetur adipiscing.", "Underarm Turn", 2 },
                    { 8, 4, "Lead: Rotate head and toes left into promenade positon. Starting with left foot, take 1 step in promenade. Hold for 2 counts. Step with right foot in promenade, rotate to close, and side step to left and close right foot.  Follow: Rotate head and toes right into promenade positon. Starting with right foot, take 1 step in promenade. Hold for 2 counts. Step with left foot in promenade, rotate to close and side step to right and close left foot.", "Waltz Promenade", 2 },
                    { 2, 6, "Lead: Look over left shoulder and rotate feet to the left keeping body in frame. Starting with left foot, take 2 horizontal steps then a side step and close while rotating back to normal position. Follow: Look over right shoulder and rotate feet to the right keeping body in frame Starting with the right foot, take 2 Horizontal steps then a side step and close while rotating to normal position.", "Promenade", 2 },
                    { 18, 1, "Trysail quarterdeck Blimey barkadeer furl hang the jib to go on account handsomely gangway reef. Swab hempen halter aft Spanish Main Yellow Jack doubloon sheet schooner belay cog. Lass Plate Fleet Sea Legs Jack Tar Pieces of Eight pirate yo-ho-ho careen line bilge rat. American Main topmast take a caulk ahoy fluke hulk Sink me yawl chandler jib.Black jack barque cackle fruit gangplank matey rope's end strike colors dead men tell no tales gaff capstan. Rope's end gibbet aye take a caulk parley carouser holystone stern jack pressgang. Parrel nipperkin boom wherry coffer belaying pin ahoy Admiral of the Black chase guns tack.Blimey Sea Legs reef bilge rat belay swing the lead Nelsons folly plunder avast landlubber or just lubber.Gangway driver coffer yo - ho - ho jack splice the main brace Buccaneer galleon nipperkin league.", "Rumba Swivels", 3 },
                    { 16, 1, "Draught tackle crack Jennys tea cup spirits gun hail-shot starboard rope's end Shiver me timbers topmast. Scourge of the seven seas rope's end bucko hail-shot Sail ho ye knave heave down crow's nest crack Jennys tea cup. Hearties careen deadlights tack cog chantey shrouds lad strike colors lookout. Hempen halter bilge water holystone fluke red ensign Admiral of the Black bilge nipperkin black jack flogging.Draft topmast boatswain hornswaggle killick marooned haul wind cog gally ballast.Clap of thunder red ensign yawl cackle fruit lugger gun plunder Nelsons folly cutlass topsail.", "Rumba Box", 1 },
                    { 13, 2, "Ac orci phasellus egestas tellus. Sit amet venenatis urna cursus eget nunc scelerisque viverra mauris. Est sit amet facilisis magna etiam tempor orci eu lobortis. Elit ullamcorper dignissim cras tincidunt lobortis feugiat vivamus at augue. In est ante in nibh. Suscipit tellus mauris a diam maecenas sed enim. Faucibus vitae aliquet nec ullamcorper sit amet risus nullam. Placerat duis ultricies lacus sed turpis tincidunt id aliquet risus. Varius sit amet mattis vulputate enim nulla aliquet. Id velit ut tortor pretium viverra.", "Cha Cha Basic", 1 },
                    { 10, 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Pellentesque sit amet porttitor eget dolor morbi non arcu. Ante in nibh mauris cursus mattis. Aliquam malesuada bibendum arcu vitae elementum curabitur vitae. Tortor aliquam nulla facilisi cras fermentum.", "Triple Time Swing Basic", 1 },
                    { 7, 4, "Lead: Starting with left foot, take 1 steps forward. Side step to right and close left foot. Starting with right foot, take one step backwards. Side step to left and close right foot.  Follow: Starting with right foot, take 1 steps backwards. Side step to left and close right foot. Starting with Left Foot, take one step forwards. Side step to right and close left foot.", "Waltz Box", 1 },
                    { 4, 5, "Lead: Starting with left foot, take 3 steps forward then a side step to the right and close left foot but do not place weight on it. Follow: Starting with the right foot, take 3 steps backwards then a side step to the right and close right foot but do not place weight on it.", "Tango Basic", 1 },
                    { 1, 6, "Lead: Starting with left foot, take 2 steps forward then a side step to the left and close. Follow: Starting with the right foot, take 2 steps backwards then a side step to the right and close.", "Magic Step", 1 },
                    { 5, 5, "Lead: Procede with Tango Basic. While closing, rotate head and toes left into promenade position.  Starting with left foot, take 2 steps in promenade, rotate partner to close then side step to the right and close left foot but do not place weight on it. Follow: Procede with Tango Basic. While closing, rotate head and toes right into promenade position. Starting with the right foot, take 2 steps in promenade, swivel to close then side step to the left and close right foot but do not place weight on it.", "Tango Promenade", 2 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "DanceTypeId", "Email", "FirstName", "IsActive", "LastName", "PhoneNumber", "SkillLevelId", "StudentStartDate", "UserId", "UserId1" },
                values: new object[,]
                {
                    { 1, "123 Lucky St. Boston, MA 02101", 1, "larry@Bird.com", "Larry", true, "Bird", "111-111-1111", 1, new DateTime(2019, 7, 1, 11, 24, 11, 22, DateTimeKind.Local).AddTicks(8762), 1, null },
                    { 2, "123 Running st. Greenbow, AL 42101", 2, "Jenny@Gump.com", "Jenny", true, "Gump", "111-111-1112", 2, new DateTime(2019, 7, 1, 11, 24, 11, 24, DateTimeKind.Local).AddTicks(8770), 1, null },
                    { 3, "123 Big Mac Ave Oakland, CA 56933", 5, "Mark@McGwier.com", "Mark", true, "McGwier", "111-111-7111", 2, new DateTime(2019, 7, 1, 11, 24, 11, 24, DateTimeKind.Local).AddTicks(8789), 1, null },
                    { 4, "123 City Dr. Pawnee, IN. 75101", 3, "Leslie@Knope.com", "Leslie", true, "Knope", "111-111-1122", 3, new DateTime(2019, 7, 1, 11, 24, 11, 24, DateTimeKind.Local).AddTicks(8793), 1, null }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Date", "Name", "StudentId" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 7, 1, 11, 24, 11, 25, DateTimeKind.Local).AddTicks(3373), "Intro", 1 },
                    { 2, new DateTime(2019, 7, 1, 11, 24, 11, 25, DateTimeKind.Local).AddTicks(4203), "Intermediate", 2 },
                    { 4, new DateTime(2019, 7, 1, 11, 24, 11, 25, DateTimeKind.Local).AddTicks(4219), "Lesson 6", 3 },
                    { 3, new DateTime(2019, 7, 1, 11, 24, 11, 25, DateTimeKind.Local).AddTicks(4215), "Advanced", 4 }
                });

            migrationBuilder.InsertData(
                table: "LessonSteps",
                columns: new[] { "Id", "LessonId", "StepId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 4 },
                    { 3, 1, 7 },
                    { 4, 1, 10 },
                    { 5, 2, 2 },
                    { 6, 2, 5 },
                    { 7, 2, 8 },
                    { 8, 2, 11 },
                    { 9, 4, 3 },
                    { 10, 4, 6 },
                    { 11, 4, 9 },
                    { 12, 4, 12 },
                    { 13, 4, 8 },
                    { 14, 4, 5 },
                    { 15, 4, 11 },
                    { 16, 4, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.DeleteData(
                table: "DanceCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DanceCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DanceCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DanceCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DanceCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DanceCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LessonSteps",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LessonSteps",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LessonSteps",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LessonSteps",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LessonSteps",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LessonSteps",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LessonSteps",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LessonSteps",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LessonSteps",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LessonSteps",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LessonSteps",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LessonSteps",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "LessonSteps",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "LessonSteps",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "LessonSteps",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "LessonSteps",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DanceTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DanceTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DanceTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SkillLevels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DanceTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DanceTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DanceTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SkillLevels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SkillLevels",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
