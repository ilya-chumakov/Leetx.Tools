namespace Leetx.Tools.Tests
{
    public class TreeReader_Tests
    {
        [Fact]
        public void CreateBinaryTree_Empty_RN()
        {
            var actual = TreeReader.SelectValuesToArray(null);
            Assert.Empty(actual);
        }

        [Fact]
        public void CreateBinaryTree_Single_OK()
        {
            var input = new TreeNode(5);
            var actual = TreeReader.SelectValuesToArray(input);
            Assert.Equal(new int?[] { 5 }, actual);
        }

        [Fact]
        public void CreateBinaryTree_LeftSubtree_OK()
        {
            var input = new TreeNode(1);
            input.left = new TreeNode(2);
            var actual = TreeReader.SelectValuesToArray(input);
            Assert.Equal(new int?[] { 1, 2 }, actual);
        }

        [Fact]
        public void CreateBinaryTree_RightSubtree_OK()
        {
            var input = new TreeNode(1);
            input.right = new TreeNode(2);
            var actual = TreeReader.SelectValuesToArray(input);
            Assert.Equal(new int?[] { 1, null, 2 }, actual);
        }
        [Fact]
        public void CreateBinaryTree_Complex_OK()
        {
            var input = new TreeNode(1,
                new TreeNode(2, new TreeNode(4)),
                new TreeNode(3)
                );
            var actual = TreeReader.SelectValuesToArray(input);
            Assert.Equal(new int?[] { 1, 2, 3, 4 }, actual);
        }
    }
}