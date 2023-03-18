namespace Leetx.Tools.Tests
{
    public class TreeBuilder_Tests
    {
        [Fact]
        public void CreateBinaryTree_Empty_RN()
        {
            var actual = TreeBuilder.CreateBinaryTree(new int?[] { });
            Assert.Null(actual);
        }

        [Fact]
        public void CreateBinaryTree_Single_OK()
        {
            var actual = TreeBuilder.CreateBinaryTree(new int?[] { 5 });
            Assert.Equal(5, actual.val);
            Assert.Null(actual.left);
            Assert.Null(actual.right);
        }

        [Fact]
        public void CreateBinaryTree_LeftSubtree_OK()
        {
            var actual = TreeBuilder.CreateBinaryTree(new int?[] { 1, 2 });
            
            Assert.Equal(1, actual.val);
            Assert.Equal(2, actual.left!.val);
            
            Assert.Null(actual.left.left);
            Assert.Null(actual.left.right);
            Assert.Null(actual.right);
        }

        [Fact]
        public void CreateBinaryTree_RightSubtree_OK()
        {
            var actual = TreeBuilder.CreateBinaryTree(new int?[] { 1, null, 2 });
            Assert.Equal(1, actual.val);
            Assert.Equal(2, actual.right.val);

            Assert.Null(actual.right.left);
            Assert.Null(actual.right.right);
            Assert.Null(actual.left);
        }
    }
}