// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package system.collections;

@net.sf.jni4net.attributes.ClrInterface
public interface IDictionary extends system.collections.ICollection, system.collections.IEnumerable {
    
    //<generated-interface>
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)LSystem/Object;")
    system.Object getItem(system.Object key);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;LSystem/Object;)V")
    void setItem(system.Object key, system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Collections/ICollection;")
    system.collections.ICollection getKeys();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Collections/ICollection;")
    system.collections.ICollection getValues();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)Z")
    boolean Contains(system.Object key);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;LSystem/Object;)V")
    void Add(system.Object key, system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    void Clear();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    boolean isReadOnly();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    boolean isFixedSize();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)V")
    void Remove(system.Object key);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Collections/IDictionaryEnumerator;")
    system.collections.IDictionaryEnumerator GetEnumerator();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Collections/IEnumerator;")
    system.collections.IEnumerator IEnumerable_GetEnumerator();
    //</generated-interface>
}
